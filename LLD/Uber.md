# Uber/Ola low level system design

    - Important elements

        1. Rider
        2. Drivers/Cabs             [Assuming every driver have one cab and every cab have one driver.]

    - Important features:

        1. Trip creaiton logic

        2. Driver Matching 

            a. Get the nearest drivers and send request to them, first one who accepts that will full fill the trip.
            b. Or we might want to assign driver who haven't full alot of trip in last 24 hrs.
            c. Or may be combination of these conditions.

        3. Pricing

            a. Default pricing like per km fare.
            b. Or peak rush time we might want to charge more.
            c. Or may be it can depends on weather condition like during rain we will charge more. 
            d. Or may be combination of all.

        4. Riders / Drivers managing

            a. RiderManager         [Take care of rider related operations, like store rider details]

                - 1 instance of "RiderManager" who will take care of all riders - Singleton Design Pattern
                - RiderManager has map, which has all the riders details corresponding to a rider id.
                - Rider class
            
            b. DriverManager

                - Singleton Design Pattern
                - Has map which has all the driver details like isAvailable, cabDetails.. etc
                - Driver class

    - Implemetation

        1. DriverMatchingStrategy

            a. LeastTimeTakenDMStrategy
                - matchDriver

        2. PricingStrategy

            a. DefaultPricingStrategy
                - calculatePrice        [method]

            b. TrafficBasedStrategy
                - calculatePrice

        3. StrategyManager

        4. TripMetaData                 [This class has limited trip details which only "StrategyManager" requires.]

        5. TripManager