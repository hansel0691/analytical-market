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
                        Date = GetValue<DateTime>(workSheet.Cells[start + (int)IncomeStatementKeys.Date, i].Value),
                        Revenue = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.Revenue, i].Value),
                        CostOfRevenue = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.CostOfRevenue, i].Value),
                        GrossProfit = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.GrossProfit, i].Value),
                        Research_Development = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.Research_Development, i].Value),
                        SellingGeneral_Administrative = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.SellingGeneral_Administrative, i].Value),
                        OperatingExpenses = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.OperatingExpenses, i].Value),
                        OperatingIncome = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.OperatingIncome, i].Value),
                        EBIT = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.EBIT, i].Value),
                        InterestExpense = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.InterestExpense, i].Value),
                        EarningsBeforeTax = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.EarningsBeforeTax, i].Value),
                        IncomeTaxExpense = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.IncomeTaxExpense, i].Value),
                        EBITDA = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.EBITDA, i].Value),
                        DiscontinuedOperations = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.DiscontinuedOperations, i].Value),
                        NonControllingInterests = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.NonControllingInterests, i].Value),
                        CommonNetIncome = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.CommonNetIncome, i].Value),
                        NetIncome = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.NetIncome, i].Value),
                        ConsolidatedIncome = GetValue<double>(workSheet.Cells[start + (int)IncomeStatementKeys.ConsolidatedIncome, i].Value)
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
                        Date = GetValue<DateTime>(workSheet.Cells[start + (int)BalanceSheetKeys.Date, i].Value),
                        Cash_Equivalents = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.Cash_Equivalents, i].Value),
                        CurrentInvestments = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.CurrentInvestments, i].Value),
                        Investments = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.Investments, i].Value),
                        NetReceivables = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.NetReceivables, i].Value),
                        Inventory = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.Inventory, i].Value),
                        CurrentAssets = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.CurrentAssets, i].Value),
                        Property_Equipment = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.Property_Equipment, i].Value),
                        Goodwill_IntangibleAssets = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.Goodwill_IntangibleAssets, i].Value),
                        TaxAssets = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.TaxAssets, i].Value),
                        NonCurrentAssets = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.NonCurrentAssets, i].Value),
                        TotalAssets = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.TotalAssets, i].Value),
                        AccountsPayables = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.AccountsPayables, i].Value),
                        CurrentDebt = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.CurrentDebt, i].Value),
                        CurrentLiabilities = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.CurrentLiabilities, i].Value),
                        NonCurrentLiabilities = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.NonCurrentLiabilities, i].Value),
                        TotalDebt = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.TotalDebt, i].Value),
                        DeferredRevenue = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.DeferredRevenue, i].Value),
                        TaxLiabilities = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.TaxLiabilities, i].Value),
                        DepositLiabilities = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.DepositLiabilities, i].Value),
                        TotalLiabilities = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.TotalLiabilities, i].Value),
                        RetainedEarnings = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.RetainedEarnings, i].Value),
                        ShareholdersEquity = GetValue<double>(workSheet.Cells[start + (int)BalanceSheetKeys.ShareholdersEquity, i].Value)
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
