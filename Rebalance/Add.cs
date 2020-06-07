using System.Collections.Generic;

namespace JSONUtils
{

    public class Multimercado
    {
        public string CDI { get; set; }
        public string IBOVESPA { get; set; }
    }

    public class FundosDeInvestimentos
    {
        public Multimercado Multimercado { get; set; }
    }

    public class PósFixadoLiquidezDiária
    {
        public string CDI { get; set; }
        public string IBOVESPA { get; set; }
    }

    public class TítuloDeRendaFixa
    {
        public PósFixadoLiquidezDiária Pós-fixado Liquidez Diária { get; set; }
}

public class BenchmarksClassProduct
{
    public FundosDeInvestimentos Fundos de Investimentos { get; set; }
    public TítuloDeRendaFixa Título de Renda Fixa { get; set; }
        }

        public class BenchmarksClassProductGain
{
    public Fundos de Investimentos { get; set; }
public Título de Renda Fixa { get; set; }
        }

        public class Allocation
{
    public string allocation { get; set; }
    public double allocation_number { get; set; }
    public string name { get; set; }
}

public class ClassAllocation
{
    public IList<Allocation> allocation { get; set; }
    public string name { get; set; }
}

public class Added
{
    public string action { get; set; }
    public double action_value { get; set; }
    public int allocation { get; set; }
    public string category { get; set; }
    public object deadline_fixed_income { get; set; }
    public string disclaimer { get; set; }
    public string fee_fixed_income { get; set; }
    public double financial_balance { get; set; }
    public string id { get; set; }
    public int minimum_value { get; set; }
    public string name { get; set; }
    public int old_financial_balance { get; set; }
    public string operation_id { get; set; }
    public string percentage { get; set; }
    public string risk { get; set; }
    public string type { get; set; }
}

public class NewBenchmarks
{
    public string CDI { get; set; }
    public string IBOVESPA { get; set; }
}

public class NewBenchmarksNumber
{
    public double CDI { get; set; }
    public double IBOVESPA { get; set; }
}

public class NewGain
{
    public string percentage { get; set; }
    public double percentage_number { get; set; }
}

public class Benchmarks
{
    public string CDI { get; set; }
    public string IBOVESPA { get; set; }
}

public class BenchmarksNumber
{
    public double CDI { get; set; }
    public double IBOVESPA { get; set; }
}

public class Gain
{
    public string percentage { get; set; }
    public double percentage_number { get; set; }
}

public class Asset
{
    public string action { get; set; }
    public double action_value { get; set; }
    public double allocation { get; set; }
    public string category { get; set; }
    public object deadline_fixed_income { get; set; }
    public string disclaimer { get; set; }
    public string fee_fixed_income { get; set; }
    public double financial_balance { get; set; }
    public string id { get; set; }
    public int minimum_value { get; set; }
    public string name { get; set; }
    public NewBenchmarks new_benchmarks { get; set; }
    public NewBenchmarksNumber new_benchmarks_number { get; set; }
    public NewGain new_gain { get; set; }
    public double old_financial_balance { get; set; }
    public string operation_id { get; set; }
    public string percentage { get; set; }
    public string risk { get; set; }
    public string type { get; set; }
    public Benchmarks benchmarks { get; set; }
    public BenchmarksNumber benchmarks_number { get; set; }
    public Gain gain { get; set; }
}

public class Invested
{
    public int allocation { get; set; }
    public benchmarks { get; set; }
public string category { get; set; }
public string deadline_fixed_income { get; set; }
public string disclaimer { get; set; }
public string fee_fixed_income { get; set; }
public double financial_balance { get; set; }
public gain { get; set; }
            public string id { get; set; }
public int minimum_value { get; set; }
public string name { get; set; }
public string operation_id { get; set; }
public string percentage { get; set; }
public string risk { get; set; }
public string type { get; set; }
        }

        public class FinancialAssets
{
    public IList<Added> added { get; set; }
    public IList<Asset> assets { get; set; }
    public IList<Invested> invested { get; set; }
    public IList<object> rescued { get; set; }
}

public class NewBenchmarksClassProduct
{
    public Fundos de Investimentos { get; set; }
public Título de Renda Fixa { get; set; }
        }

        public class NewBenchmarksClassProductGain
{
    public Fundos de Investimentos { get; set; }
public Título de Renda Fixa { get; set; }
        }

        public class Persona
{
    public string person_description { get; set; }
    public int person_id { get; set; }
    public string scenario_description { get; set; }
    public int scenario_id { get; set; }
}

public class Benchmark
{
    public string name { get; set; }
    public string percentage { get; set; }
    public string id { get; set; }
    public double? percentage_number { get; set; }
}

public class Rentability
{
    public string percentage { get; set; }
    public double percentage_number { get; set; }
}

public class Allocation
{
    public double number_percentage { get; set; }
    public string percentage { get; set; }
}

public class Class
{
    public Allocation allocation { get; set; }
    public double balance { get; set; }
    public string name { get; set; }
}

public class ClassesCategory
{
    public allocation { get; set; }
public double balance { get; set; }
public string name { get; set; }
        }

        public class AssetsDevelopment
{
    public IList<Class> classes { get; set; }
    public IList<ClassesCategory> classes_categories { get; set; }
}

public class Benchmark
{
    public string id { get; set; }
    public string name { get; set; }
    public string percentage { get; set; }
    public double percentage_number { get; set; }
}

public class Benchmark
{
    public string id { get; set; }
    public string name { get; set; }
    public string percentage { get; set; }
    public double percentage_number { get; set; }
}

public class Category
{
    public IList<Benchmark> benchmarks { get; set; }
    public string id { get; set; }
    public string name { get; set; }
    public rentability { get; set; }
        }

        public class Class
{
    public IList<Benchmark> benchmarks { get; set; }
    public IList<Category> categories { get; set; }
    public string id { get; set; }
    public string name { get; set; }
    public rentability { get; set; }
        }

        public class Benchmark
{
    public string id { get; set; }
    public string name { get; set; }
    public string percentage { get; set; }
    public double percentage_number { get; set; }
}

public class ClassesCategory
{
    public IList<Benchmark> benchmarks { get; set; }
    public string id { get; set; }
    public string name { get; set; }
    public rentability { get; set; }
        }

        public class FinalDate
{
    public string date { get; set; }
    public int month { get; set; }
    public int year { get; set; }
}

public class InitialDate
{
    public string date { get; set; }
    public int month { get; set; }
    public int year { get; set; }
}

public class ReferenceDates
{
    public FinalDate final_date { get; set; }
    public InitialDate initial_date { get; set; }
}

public class Rent
{
    public IList<Benchmark> benchmarks { get; set; }
    public int? period { get; set; }
    public string period_type { get; set; }
    public Rentability rentability { get; set; }
    public AssetsDevelopment assets_development { get; set; }
    public double? balance { get; set; }
    public IList<Class> classes { get; set; }
    public IList<ClassesCategory> classes_categories { get; set; }
    public ReferenceDates reference_dates { get; set; }
}

public class Rentability
{
    public string name { get; set; }
    public IList<Rent> rents { get; set; }
}

public class Persona
{
    public double capital_invest { get; set; }
    public IList<IList<double>> cdi_chart_projection { get; set; }
    public double cdi_projection { get; set; }
    public string cdi_rate { get; set; }
    public IList<ClassAllocation> class_allocation { get; set; }
    public int deadline_achive_goal { get; set; }
    public FinancialAssets financial_assets { get; set; }
    public double gross_value_projection { get; set; }
    public IList<IList<double>> investment_chart_projection { get; set; }
    public string ipca_rate { get; set; }
    public string message { get; set; }
    public double net_value_cdi_projection { get; set; }
    public double net_value_projection { get; set; }
    public NewBenchmarksClassProduct new_benchmarks_class_product { get; set; }
    public NewBenchmarksClassProductGain new_benchmarks_class_product_gain { get; set; }
    public Persona persona { get; set; }
    public IList<object> recurring_product { get; set; }
    public IList<Rentability> rentabilities { get; set; }
    public string savings_rate { get; set; }
    public bool success { get; set; }
    public double value_achive_goal { get; set; }
    public double value_achive_goal_cdi { get; set; }
}

public class Benchmark
{
    public string name { get; set; }
    public string percentage { get; set; }
    public string id { get; set; }
    public double? percentage_number { get; set; }
}

public class Benchmark
{
    public string id { get; set; }
    public string name { get; set; }
    public string percentage { get; set; }
    public double percentage_number { get; set; }
}

public class Benchmark
{
    public string id { get; set; }
    public string name { get; set; }
    public string percentage { get; set; }
    public double percentage_number { get; set; }
}

public class Category
{
    public IList<Benchmark> benchmarks { get; set; }
    public string id { get; set; }
    public string name { get; set; }
    public rentability { get; set; }
        }

        public class Class
{
    public IList<Benchmark> benchmarks { get; set; }
    public IList<Category> categories { get; set; }
    public string id { get; set; }
    public string name { get; set; }
    public rentability { get; set; }
        }

        public class Benchmark
{
    public string id { get; set; }
    public string name { get; set; }
    public string percentage { get; set; }
    public double percentage_number { get; set; }
}

public class ClassesCategory
{
    public IList<Benchmark> benchmarks { get; set; }
    public string id { get; set; }
    public string name { get; set; }
    public rentability { get; set; }
        }

        public class Rent
{
    public IList<Benchmark> benchmarks { get; set; }
    public int? period { get; set; }
    public string period_type { get; set; }
    public rentability { get; set; }
public assets_development { get; set; }
            public double? balance { get; set; }
public IList<Class> classes { get; set; }
public IList<ClassesCategory> classes_categories { get; set; }
public reference_dates { get; set; }
        }

        public class Rentability
{
    public string name { get; set; }
    public IList<Rent> rents { get; set; }
}

public class Add
{
    public BenchmarksClassProduct benchmarks_class_product { get; set; }
    public BenchmarksClassProductGain benchmarks_class_product_gain { get; set; }
    public int deadline { get; set; }
    public int financial_goal { get; set; }
    public double initial_capital { get; set; }
    public object investment_goal_id { get; set; }
    public string investment_goal_name { get; set; }
    public int investment_period { get; set; }
    public IList<Persona> personas { get; set; }
    public IList<Rentability> rentabilities { get; set; }
}

}
