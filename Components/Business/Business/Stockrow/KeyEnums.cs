using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Business.Business.Stockrow
{
    public enum IncomeStatementKeys
    {
        Date = 1,
        Revenue = 2,
        CostOfRevenue = 4,
        GrossProfit = 5,
        Research_Development = 6,
        SellingGeneral_Administrative = 7,
        OperatingExpenses = 8,
        OperatingIncome = 9,
        EarningsBeforeTax = 11,
        EBIT = 29,
        EBITDA = 28,
        InterestExpense = 10,
        IncomeTaxExpense = 12,
        DiscontinuedOperations = 14,
        NonControllingInterests = 13,
        CommonNetIncome = 17,
        NetIncome = 15,
        ConsolidatedIncome = 30
    }

    public enum BalanceSheetKeys
    {
        Date = 1,
        Cash_Equivalents = 2,
        CurrentInvestments = 3,
        Investments = 27,
        NetReceivables = 5,
        Inventory = 6,
        CurrentAssets = 7,
        Property_Equipment = 8,
        Goodwill_IntangibleAssets = 9,
        TaxAssets = 11,
        NonCurrentAssets = 12,
        TotalAssets = 13,
        AccountsPayables = 14,
        CurrentDebt = 15,
        CurrentLiabilities = 16,
        NonCurrentLiabilities = 22,
        TotalDebt = 18,
        DeferredRevenue = 19,
        TaxLiabilities = 20,
        DepositLiabilities = 21,
        TotalLiabilities = 23,
        RetainedEarnings = 25,
        ShareholdersEquity = 26
    }

    public enum CashFlowKeys
    {
        Date = 1,
        Depreciation_Amortization = 2,
        ShareBasedCompensation = 3,
        OperatingCashFlow = 4,
        CapitalExpenditure = 5,
        BusinessAcquisitions_Disposals = 6,
        InvestmentAcquisitions_Disposals = 7,
        InvestingCashFlow = 8,
        DebtSecuritiesRepayment = 9,
        EquitySharesPurchase = 10,
        DividendsPayment_Distributions = 11,
        FinancingCashFlow = 12,
        FreeCashFlow = 15
    }
}
