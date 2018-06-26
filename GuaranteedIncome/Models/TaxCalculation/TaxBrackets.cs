﻿using System;

namespace GuaranteedIncome.Models
{
    /*
     * Properties are 
     *  - IncomeRateForBracket[bracketNumber]
     *  - CapitalGainsRateForBracket[bracketNumber]
     *  
     * Methods are
     *  - IncomeBracketsFor(filingStatus:) -> brackets
     *  - CaptialGainsBracketsFor(filingStatus:) -> brackets
     *  
     *  - IncomeBracketFor(filingStatus:, income:) -> bracketNumber
     *  - CapitalGainsBracketFor(filingStatus:, income:) -> bracketNumber
     */
    public class TaxBrackets
    {
        public static decimal[] FederalIncomeRateForBracket = new decimal[] { 0.10M, 0.12M, 0.22M, 0.24M, 0.32M, 0.35M, 0.37M };
        public static decimal[] VaStateIncomeRateForBracket = new decimal[] { 0.02M, 0.03M, 0.05M, 0.0575M };
        public static decimal[] CapitalGainsRateForBracket = { 0.10M, 0.15M, 0.20M };

        public static (decimal lowerBound, decimal upperBound)[] FederalIncomeBracketsFor(FilingStatus filingStatus)
        {
            switch (filingStatus)
            {
                case FilingStatus.Joint:
                    return new(decimal lowerBound, decimal upperBound)[] {
                        (0.00M, 19050.00M),
                        (19050.01M, 77400.00M),
                        (77400.01M, 165000.00M),
                        (165000.01M, 315000.00M),
                        (315000.01M, 400000.00M),
                        (400000.01M, 600000.00M),
                        (600000.01M, Decimal.MaxValue)
                    };
                case FilingStatus.HeadOfHousehold:
                    return new(decimal lowerBound, decimal upperBound)[] {
                        (0.00M, 13600.00M),
                        (13600.01M, 51800.00M),
                        (51800.01M, 82500.00M),
                        (82500.01M, 157500.00M),
                        (157500.01M, 200000.00M),
                        (200000.01M, 500000.00M),
                        (500000.01M, Decimal.MaxValue)
                    };
                case FilingStatus.Unmarried:
                    return new(decimal lowerBound, decimal upperBound)[] {
                        (0.00M, 9525.00M),
                        (9525.01M, 38700.00M),
                        (38700.01M, 82500.00M),
                        (82500.01M, 157500.00M),
                        (157500.01M, 200000.00M),
                        (500000.01M, Decimal.MaxValue)
                    };
                case FilingStatus.MarriedSeparate:
                    return new(decimal lowerBound, decimal upperBound)[] {
                        (0.00M, 9525.00M),
                        (9525.01M, 38700.00M),
                        (38700.01M, 82500.00M),
                        (82500.01M, 157500.00M),
                        (157500.01M, 300000.00M),
                        (300000.01M, Decimal.MaxValue)
                    };
                default:
                    Console.WriteLine("Invalid filing status");
                    return null;
            }
        }

        public static (decimal lowerBound, decimal upperBound)[] VaStateBrackets()
        {
            return new(decimal lowerBound, decimal upperBound)[] {
                (0.00M, 3000.49M),
                (3000.50M, 5000.49M),
                (5000.50M, 17000.49M),
                (17000.50M, Decimal.MaxValue)
            };
        }

        public static (decimal lowerBound, decimal upperBound)[] CapitalGainsBracketsFor(FilingStatus filingStatus)
        {
            switch (filingStatus)
            {
                case FilingStatus.Joint:
                    return new(decimal lowerBound, decimal upperBound)[] {
                        (0.00M, 77200.00M),
                        (77200.01M, 479000.00M),
                        (479000.01M, Decimal.MaxValue)
                    };
                case FilingStatus.HeadOfHousehold:
                    return new(decimal lowerBound, decimal upperBound)[] {
                        (0.00M, 51700.00M),
                        (51700.01M, 452400.00M),
                        (452400.01M, Decimal.MaxValue)
                    };
                case FilingStatus.Unmarried:
                    return new(decimal lowerBound, decimal upperBound)[] {
                        (0.00M, 38600.00M),
                        (38600.01M, 425800.00M),
                        (425800.01M, Decimal.MaxValue)
                    };
                case FilingStatus.MarriedSeparate:
                    return new(decimal lowerBound, decimal upperBound)[] {
                        (0.00M, 38600.00M),
                        (38600.01M, 239500.00M),
                        (239500.01M, Decimal.MaxValue)
                    };
                default:
                    Console.WriteLine("Invalid filing status");
                    return null;
            }
        }

        public static int FederalIncomeBracketFor(FilingStatus filingStatus, decimal income) => BracketForBrackets(FederalIncomeBracketsFor(filingStatus), income);

        public static int VaStateIncomeBracketFor(decimal income) => BracketForBrackets(VaStateBrackets(), income);

        public static int CapitalGainsBracketFor(FilingStatus filingStatus, decimal income) => BracketForBrackets(CapitalGainsBracketsFor(filingStatus), income);

        private static int BracketForBrackets((decimal lowerBound, decimal upperBound)[] brackets, decimal income)
        {
            for (var i = 0; i < brackets.Length; i++)
            {
                if (income >= brackets[i].lowerBound && income <= brackets[i].upperBound) { return i; }
            }

            return 0;
        }
        
    }
}
