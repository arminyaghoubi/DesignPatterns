using AbstractFactory.Services.Financial;
using AbstractFactory.Services.Informational;

namespace AbstractFactory.Factories;

internal interface ITransactionFactory
{
    IFinancialTransaction CreateFinancialTransaction();
    IInformationalTransaction CreateInfomationalTransaction();
}
