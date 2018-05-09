using AnalyticalMarket.Entities.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AnalyticalMarket.Business.Business.Stockrow
{
    public static class StockrowFormatter
    {
        public static IEnumerable<IncomeStatement> ParseIncomeStatement(ExcelWorksheet workSheet)
        {
            var quarters = new List<IncomeStatement>();

            if (workSheet == null)
                throw new Exception("Invalid worksheet parameter");

            for (int start = workSheet.Dimension.Start.Column, i = workSheet.Dimension.Start.Row; i <= workSheet.Dimension.End.Row; i++)
            {
                var dateValue = workSheet.Cells[start, i].Value;

                DateTime statementDate;
                if (dateValue != null && DateTime.TryParse(dateValue.ToString(), out statementDate))
                {
                    yield return new IncomeStatement()
                    {
                        PeriodEnding = GetValue<DateTime>(workSheet.Cells[(int)IncomeStatementKeys.Date, i].Value),
                        Revenue = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.Revenue, i].Value),
                        CostOfRevenue = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.CostOfRevenue, i].Value),
                        GrossProfit = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.GrossProfit, i].Value),
                        Research_Development = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.Research_Development, i].Value),
                        SellingGeneral_Administrative = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.SellingGeneral_Administrative, i].Value),
                        OperatingExpenses = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.OperatingExpenses, i].Value),
                        OperatingIncome = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.OperatingIncome, i].Value),
                        EBIT = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.EBIT, i].Value),
                        InterestExpense = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.InterestExpense, i].Value),
                        EarningsBeforeTax = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.EarningsBeforeTax, i].Value),
                        IncomeTaxExpense = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.IncomeTaxExpense, i].Value),
                        EBITDA = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.EBITDA, i].Value),
                        DiscontinuedOperations = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.DiscontinuedOperations, i].Value),
                        NonControllingInterests = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.NonControllingInterests, i].Value),
                        CommonNetIncome = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.CommonNetIncome, i].Value),
                        NetIncome = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.NetIncome, i].Value),
                        ConsolidatedIncome = GetValue<double>(workSheet.Cells[(int)IncomeStatementKeys.ConsolidatedIncome, i].Value)
                    };
                }
            }

            yield break;
        }

        public static IEnumerable<BalanceSheet> ParseBalanceSheet(ExcelWorksheet workSheet)
        {
            var quarters = new List<BalanceSheet>();

            if (workSheet == null)
                throw new Exception("Invalid worksheet parameter");

            for (int start = workSheet.Dimension.Start.Column, i = workSheet.Dimension.Start.Row; i <= workSheet.Dimension.End.Row; i++)
            {
                var dateValue = workSheet.Cells[start, i].Value;

                DateTime statementDate;
                if (dateValue != null && DateTime.TryParse(dateValue.ToString(), out statementDate))
                {
                    yield return new BalanceSheet()
                    {
                        PeriodEnding = GetValue<DateTime>(workSheet.Cells[(int)BalanceSheetKeys.Date, i].Value),
                        Cash_Equivalents = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.Cash_Equivalents, i].Value),
                        CurrentInvestments = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.CurrentInvestments, i].Value),
                        Investments = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.Investments, i].Value),
                        NetReceivables = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.NetReceivables, i].Value),
                        Inventory = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.Inventory, i].Value),
                        CurrentAssets = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.CurrentAssets, i].Value),
                        Property_Equipment = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.Property_Equipment, i].Value),
                        Goodwill_IntangibleAssets = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.Goodwill_IntangibleAssets, i].Value),
                        TaxAssets = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.TaxAssets, i].Value),
                        NonCurrentAssets = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.NonCurrentAssets, i].Value),
                        TotalAssets = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.TotalAssets, i].Value),
                        AccountsPayables = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.AccountsPayables, i].Value),
                        CurrentDebt = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.CurrentDebt, i].Value),
                        CurrentLiabilities = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.CurrentLiabilities, i].Value),
                        NonCurrentLiabilities = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.NonCurrentLiabilities, i].Value),
                        TotalDebt = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.TotalDebt, i].Value),
                        DeferredRevenue = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.DeferredRevenue, i].Value),
                        TaxLiabilities = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.TaxLiabilities, i].Value),
                        DepositLiabilities = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.DepositLiabilities, i].Value),
                        TotalLiabilities = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.TotalLiabilities, i].Value),
                        RetainedEarnings = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.RetainedEarnings, i].Value),
                        ShareholdersEquity = GetValue<double>(workSheet.Cells[(int)BalanceSheetKeys.ShareholdersEquity, i].Value)
                    };
                }
            }

            yield break;
        }

        public static IEnumerable<CashFlow> ParseCashFlow(ExcelWorksheet workSheet)
        {
            var quarters = new List<CashFlow>();

            if (workSheet == null)
                throw new Exception("Invalid worksheet parameter");

            for (int start = workSheet.Dimension.Start.Column, i = workSheet.Dimension.Start.Row; i <= workSheet.Dimension.End.Row; i++)
            {
                var dateValue = workSheet.Cells[start, i].Value;

                DateTime statementDate;
                if (dateValue != null && DateTime.TryParse(dateValue.ToString(), out statementDate))
                {
                    yield return new CashFlow()
                    {
                        PeriodEnding = GetValue<DateTime>(workSheet.Cells[(int)CashFlowKeys.Date, i].Value),
                        BusinessAcquisitions_Disposals = GetValue<double>(workSheet.Cells[(int)CashFlowKeys.BusinessAcquisitions_Disposals, i].Value),
                        CapitalExpenditure = GetValue<double>(workSheet.Cells[(int)CashFlowKeys.CapitalExpenditure, i].Value),
                        DebtSecuritiesRepayment = GetValue<double>(workSheet.Cells[(int)CashFlowKeys.DebtSecuritiesRepayment, i].Value),
                        Depreciation_Amortization = GetValue<double>(workSheet.Cells[(int)CashFlowKeys.Depreciation_Amortization, i].Value),
                        DividendsPayment_Distributions = GetValue<double>(workSheet.Cells[(int)CashFlowKeys.DividendsPayment_Distributions, i].Value),
                        EquitySharesPurchase = GetValue<double>(workSheet.Cells[(int)CashFlowKeys.EquitySharesPurchase, i].Value),
                        FinancingCashFlow = GetValue<double>(workSheet.Cells[(int)CashFlowKeys.FinancingCashFlow, i].Value),
                        FreeCashFlow = GetValue<double>(workSheet.Cells[(int)CashFlowKeys.FreeCashFlow, i].Value),
                        InvestingCashFlow = GetValue<double>(workSheet.Cells[(int)CashFlowKeys.InvestingCashFlow, i].Value),
                        InvestmentAcquisitions_Disposals = GetValue<double>(workSheet.Cells[(int)CashFlowKeys.InvestmentAcquisitions_Disposals, i].Value),
                        OperatingCashFlow = GetValue<double>(workSheet.Cells[(int)CashFlowKeys.OperatingCashFlow, i].Value),
                        ShareBasedCompensation = GetValue<double>(workSheet.Cells[(int)CashFlowKeys.ShareBasedCompensation, i].Value)
                    };
                }
            }

            yield break;
        }


        private static T GetValue<T>(object obj)
        {
            if (obj == null)
                throw new Exception("Invalid obj parameter");

            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                if (converter != null)
                    return (T)converter.ConvertFromString(obj.ToString());
                else
                    return default(T);
            }
            catch (Exception e)
            {
                throw new Exception("Invalid obj parameter");
            }
        }

    }
}
