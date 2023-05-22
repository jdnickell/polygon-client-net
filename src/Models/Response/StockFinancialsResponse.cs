namespace polygon_client_net.Models.Response;

public class Assets
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public long? Value { get; set; } = default!;
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

public class BasicEarningsPerShare
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public double? Value { get; set; } = default!;
}

public class BenefitsCostsExpenses
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
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

public class ComprehensiveIncomeLoss
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class ComprehensiveIncomeLossAttributableToNoncontrollingInterest
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class ComprehensiveIncomeLossAttributableToParent
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class CostOfRevenue
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class CostsAndExpenses
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class CurrentAssets
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class CurrentLiabilities
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class DilutedEarningsPerShare
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public double? Value { get; set; } = default!;
}

public class Equity
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class EquityAttributableToNoncontrollingInterest
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class EquityAttributableToParent
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class ExchangeGainsLosses
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class Financials
{
    public BalanceSheet BalanceSheet { get; set; } = default!;
    public CashFlowStatement CashFlowStatement { get; set; } = default!;
    public ComprehensiveIncome ComprehensiveIncome { get; set; } = default!;
    public IncomeStatement IncomeStatement { get; set; } = default!;
}

public class GrossProfit
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class IncomeLossFromContinuingOperationsAfterTax
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class IncomeLossFromContinuingOperationsBeforeTax
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
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

public class IncomeTaxExpenseBenefit
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class InterestExpenseOperating
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class Liabilities
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class LiabilitiesAndEquity
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public long? Value { get; set; } = default!;
}

public class NetCashFlow
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class NetCashFlowContinuing
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class NetCashFlowFromFinancingActivities
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class NetCashFlowFromFinancingActivitiesContinuing
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class NetCashFlowFromInvestingActivities
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class NetCashFlowFromInvestingActivitiesContinuing
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class NetCashFlowFromOperatingActivities
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class NetCashFlowFromOperatingActivitiesContinuing
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class NetIncomeLoss
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class NetIncomeLossAttributableToNoncontrollingInterest
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class NetIncomeLossAttributableToParent
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class NetIncomeLossAvailableToCommonStockholdersBasic
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class NoncurrentAssets
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class NoncurrentLiabilities
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class OperatingExpenses
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class OperatingIncomeLoss
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class OtherComprehensiveIncomeLoss
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class OtherComprehensiveIncomeLossAttributableToParent
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class ParticipatingSecuritiesDistributedAndUndistributedEarningsLossBasic
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class PreferredStockDividendsAndOtherAdjustments
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class StockFinancialsResponseResults
{
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
}

public class Revenues
{
    public string Label { get; set; } = default!;
    public int? Order { get; set; } = default!;
    public string Unit { get; set; } = default!;
    public int? Value { get; set; } = default!;
}

public class StockFinancialsResponse
{
    public int? Count { get; set; } = default!;
    public string NextUrl { get; set; } = default!;
    public string RequestId { get; set; } = default!;
    public List<StockFinancialsResponseResults> StockFinancialsResponseResults { get; set; } = default!;
    public string Status { get; set; } = default!;
}
