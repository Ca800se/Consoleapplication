namespace WeightConverter
{
    
        public static class WeightConverter
        {
            
            private const double KgPerPound = 0.4536;        
            private const double KgPerApothecaryOunce = 0.0311035; 
            private const double KgPerSlug = 14.5939;        

           
            public static double ConvertPoundsToKg(double pounds)
            {
                return pounds * KgPerPound;
            }

         
            public static double ConvertKgToPounds(double kilograms)
            {
                return kilograms / KgPerPound;
            }

         

          
            public static double ConvertApothecaryOuncesToGrams(double ounces)
            {
                
                return ounces * KgPerApothecaryOunce * 1000;
            }

            public static double ConvertGramsToApothecaryOunces(double grams)
            {
             
                double kilograms = grams / 1000;
                return kilograms / KgPerApothecaryOunce;
            }

            public static double ConvertKgToSlugs(double kilograms)
            {
                return kilograms / KgPerSlug;
            }

            
            public static double ConvertSlugsToKg(double slugs)
            {
                return slugs * KgPerSlug;
            }
        }

    
}
