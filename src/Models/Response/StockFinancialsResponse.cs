namespace polygon_client_net.Models.Response;

public class Assets : LineItem
{
}

public class BalanceSheet
{
    public Assets Assets { get; set; } = default!;
    public CurrentAssets CurrentAssets { get; set; } = default!;
    public CurrentLiabilities CurrentLiabilities { get; set; } = default!;
    public Equity Equity { get; set; } = default!;
    public EquityAttributableToNoncontrollingInterest? EquityAttributableToNoncontrollingInterest { get; set; } = default!;
    public EquityAttributableToParent EquityAttributableToParent { get; set; } = default!;
    public Liabilities Liabilities { get; set; } = default!;
    public LiabilitiesAndEquity LiabilitiesAndEquity { get; set; } = default!;
    public NoncurrentAssets NoncurrentAssets { get; set; } = default!;
    public NoncurrentLiabilities NoncurrentLiabilities { get; set; } = default!;
}

public class LineItem
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public double? Value { get; set; } = default!;
}

public class BasicEarningsPerShare : LineItem
{

}

public class BenefitsCostsExpenses : LineItem
{

}

public class CashFlowStatement
{
    public ExchangeGainsLosses ExchangeGainsLosses { get; set; } = default!;
    public NetCashFlow NetCashFlow { get; set; } = default!;
    public NetCashFlowContinuing NetCashFlowContinuing { get; set; } = default!;
    public NetCashFlowFromFinancingActivities NetCashFlowFromFinancingActivities { get; set; } = default!;
    public NetCashFlowFromFinancingActivitiesContinuing NetCashFlowFromFinancingActivitiesContinuing { get; set; } = default!;
    public NetCashFlowFromInvestingActivities NetCashFlowFromInvestingActivities { get; set; } = default!;
    public NetCashFlowFromInvestingActivitiesContinuing NetCashFlowFromInvestingActivitiesContinuing { get; set; } = default!;
    public NetCashFlowFromOperatingActivities NetCashFlowFromOperatingActivities { get; set; } = default!;
    public NetCashFlowFromOperatingActivitiesContinuing NetCashFlowFromOperatingActivitiesContinuing { get; set; } = default!;
}

public class ComprehensiveIncome
{
    public ComprehensiveIncomeLoss ComprehensiveIncomeLoss { get; set; } = default!;
    public ComprehensiveIncomeLossAttributableToNoncontrollingInterest ComprehensiveIncomeLossAttributableToNoncontrollingInterest { get; set; } = default!;
    public ComprehensiveIncomeLossAttributableToParent ComprehensiveIncomeLossAttributableToParent { get; set; } = default!;
    public OtherComprehensiveIncomeLoss OtherComprehensiveIncomeLoss { get; set; } = default!;
    public OtherComprehensiveIncomeLossAttributableToParent OtherComprehensiveIncomeLossAttributableToParent { get; set; } = default!;
}

public class ComprehensiveIncomeLoss : LineItem
{

}

public class ComprehensiveIncomeLossAttributableToNoncontrollingInterest : LineItem
{

}

public class ComprehensiveIncomeLossAttributableToParent : LineItem
{

}

public class CostOfRevenue : LineItem
{

}

public class CostsAndExpenses : LineItem
{

}

public class CurrentAssets : LineItem
{

}

public class CurrentLiabilities : LineItem
{

}

public class DilutedEarningsPerShare : LineItem
{

}

public class Equity : LineItem
{

}

public class EquityAttributableToNoncontrollingInterest : LineItem
{

}

public class EquityAttributableToParent : LineItem
{

}

public class ExchangeGainsLosses : LineItem
{

}

public class Financials
{
    public BalanceSheet BalanceSheet { get; set; } = default!;
    public CashFlowStatement CashFlowStatement { get; set; } = default!;
    public ComprehensiveIncome ComprehensiveIncome { get; set; } = default!;
    public IncomeStatement IncomeStatement { get; set; } = default!;
}

public class GrossProfit : LineItem
{

}

public class IncomeLossFromContinuingOperationsAfterTax : LineItem
{

}

public class IncomeLossFromContinuingOperationsBeforeTax : LineItem
{

}

public class IncomeStatement
{
    public BasicEarningsPerShare BasicEarningsPerShare { get; set; } = default!;
    public BenefitsCostsExpenses BenefitsCostsExpenses { get; set; } = default!;
    public CostOfRevenue CostOfRevenue { get; set; } = default!;
    public CostsAndExpenses CostsAndExpenses { get; set; } = default!;
    public DilutedEarningsPerShare DilutedEarningsPerShare { get; set; } = default!;
    public GrossProfit GrossProfit { get; set; } = default!;
    public IncomeLossFromContinuingOperationsAfterTax IncomeLossFromContinuingOperationsAfterTax { get; set; } = default!;
    public IncomeLossFromContinuingOperationsBeforeTax IncomeLossFromContinuingOperationsBeforeTax { get; set; } = default!;
    public IncomeTaxExpenseBenefit IncomeTaxExpenseBenefit { get; set; } = default!;
    public InterestExpenseOperating InterestExpenseOperating { get; set; } = default!;
    public NetIncomeLoss NetIncomeLoss { get; set; } = default!;
    public NetIncomeLossAttributableToNoncontrollingInterest NetIncomeLossAttributableToNoncontrollingInterest { get; set; } = default!;
    public NetIncomeLossAttributableToParent NetIncomeLossAttributableToParent { get; set; } = default!;
    public NetIncomeLossAvailableToCommonStockholdersBasic NetIncomeLossAvailableToCommonStockholdersBasic { get; set; } = default!;
    public OperatingExpenses OperatingExpenses { get; set; } = default!;
    public OperatingIncomeLoss OperatingIncomeLoss { get; set; } = default!;
    public ParticipatingSecuritiesDistributedAndUndistributedEarningsLossBasic ParticipatingSecuritiesDistributedAndUndistributedEarningsLossBasic { get; set; } = default!;
    public PreferredStockDividendsAndOtherAdjustments PreferredStockDividendsAndOtherAdjustments { get; set; } = default!;
    public Revenues Revenues { get; set; } = default!;
}

public class IncomeTaxExpenseBenefit : LineItem
{

}

public class InterestExpenseOperating : LineItem
{

}

public class Liabilities : LineItem
{

}

public class LiabilitiesAndEquity : LineItem
{

}

public class NetCashFlow : LineItem
{

}

public class NetCashFlowContinuing : LineItem
{

}

public class NetCashFlowFromFinancingActivities : LineItem
{

}

public class NetCashFlowFromFinancingActivitiesContinuing : LineItem
{
}

public class NetCashFlowFromInvestingActivities : LineItem
{
}

public class NetCashFlowFromInvestingActivitiesContinuing : LineItem
{
}

public class NetCashFlowFromOperatingActivities : LineItem
{
}

public class NetCashFlowFromOperatingActivitiesContinuing : LineItem
{
}

public class NetIncomeLoss : LineItem
{
}

public class NetIncomeLossAttributableToNoncontrollingInterest : LineItem
{
}

public class NetIncomeLossAttributableToParent : LineItem
{
}

public class NetIncomeLossAvailableToCommonStockholdersBasic : LineItem
{
}

public class NoncurrentAssets : LineItem
{
}

public class NoncurrentLiabilities : LineItem
{
}

public class OperatingExpenses : LineItem
{
}

public class OperatingIncomeLoss : LineItem
{
}

public class OtherComprehensiveIncomeLoss : LineItem
{
}

public class OtherComprehensiveIncomeLossAttributableToParent : LineItem
{
}

public class ParticipatingSecuritiesDistributedAndUndistributedEarningsLossBasic : LineItem
{
}

public class PreferredStockDividendsAndOtherAdjustments : LineItem
{
}

public class StockFinancialsResponseResults
{
    public string Id { get; set; } = default!;
    public string Cik { get; set; } = default!;
    public string CompanyName { get; set; } = default!;
    public string EndDate { get; set; } = default!;
    public string FilingDate { get; set; } = default!;
    public Financials Financials { get; set; } = default!;
    public string FiscalPeriod { get; set; } = default!;
    public string FiscalYear { get; set; } = default!;
    public string SourceFilingFileUrl { get; set; } = default!;
    public string SourceFilingUrl { get; set; } = default!;
    public string StartDate { get; set; } = default!;
    public string[] Tickers { get; set; } = default!;
    public string Timeframe { get; set; } = default!;
}

public class Revenues : LineItem
{
}
