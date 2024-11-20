using AbstractFactory.Services.Financial;
using AbstractFactory.Services.Informational;

namespace AbstractFactory.Factories;

internal class SadadTranscationFactory : ITransactionFactory
{
    public IFinancialTransaction CreateFinancialTransaction()
    {
        return new SadadFinancialTransaction();
    }

    public IInformationalTransaction CreateInfomationalTransaction()
    {
        return new SadadInformationalTransaction();
    }
}
