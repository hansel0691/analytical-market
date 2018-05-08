using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Business.Business.Stockrow
{
    public enum IncomeStatementKeys
    {
        Date = 0,
        Revenue = 1,
        CostOfRevenue = 3,
        GrossProfit = 4,
        Research_Development = 5,
        SellingGeneral_Administrative = 6,
        OperatingExpenses = 7,
        OperatingIncome = 8,
        EarningsBeforeTax = 10,
        EBIT = 28,
        EBITDA = 27,
        InterestExpense = 9,
        IncomeTaxExpense = 11,
        DiscontinuedOperations = 13,
        NonControllingInterests = 12,
        CommonNetIncome = 16,
        NetIncome = 14,
        ConsolidatedIncome = 29
    }

    public enum BalanceSheetKeys
    {
        Date = 0,
        Cash_Equivalents = 1,
        CurrentInvestments = 2,
        Investments = 26,
        NetReceivables = 4,
        Inventory = 5,
        CurrentAssets = 6,
        Property_Equipment = 7,
        Goodwill_IntangibleAssets = 8,
        TaxAssets = 10,
        NonCurrentAssets = 11,
        TotalAssets = 12,
        AccountsPayables = 13,
        CurrentDebt = 14,
        CurrentLiabilities = 15,
        NonCurrentLiabilities = 21,
        TotalDebt = 17,
        DeferredRevenue = 18,
        TaxLiabilities = 19,
        DepositLiabilities = 20,
        TotalLiabilities = 22,
        RetainedEarnings = 24,
        ShareholdersEquity = 25
    }
}
