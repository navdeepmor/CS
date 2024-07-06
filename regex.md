/.../ g

/ / - inside we write the search pattern

g   - global flag

|   - or
.
^   - negation or do the opposite 
$
*   - 0 or many times
+   - 1 or many times 
-   - 
?   - allow 0 or 1 times
()  - grouping
[]  - character sets
{}  - {min, max} explicit count
\   - escape special chars
\d  - digit
\w  - word 
\D  - NOT digit


regex = ^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$
          i     

function waitForPdfIFrame(selector) {
    return new Promise(resolve => {
        if (document.querySelector(selector)) {
            return resolve(document.querySelector(selector));
        }

        const observer = new MutationObserver(mutations => {
            if (document.querySelector(selector)) {
                observer.disconnect();
                resolve(document.querySelector(selector));
            }
        });

        // If you get "parameter 1 is not of type 'Node'" error, see https://stackoverflow.com/a/77855838/492336
        observer.observe(document.body, {
            childList: true,
            subtree: true
        });
    });
}

async function getUrlAsync(pdfIframe) {
  try {
    pdfIframe.src = "https://gssl-dev.outsystemsenterprise.com/HealthClaims/PDFLoader";
    $parameters.outUrl = await getPdfUrlAsync($parameters.InUrl);
    // Set the src attribute of the iframe with the obtained URL
    pdfIframe.src = $parameters.outUrl;
  } catch (error) {
    // const iframe = document.querySelector('.pdf-iframe');
    pdfIframe.src = "https://gssl-dev.outsystemsenterprise.com/HealthClaims/PDFErrorLoader";
    // Set the src attribute of the iframe with the obtained URL
    console.error('Error inn getUrlAsync:', error);
  }
}

// Call the function to start the process
waitForPdfIFrame('.pdf-iframe').then((elm) => getUrlAsync(elm));                