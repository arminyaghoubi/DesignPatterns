using AbstractFactory.Services.Financial;
using AbstractFactory.Services.Informational;

namespace AbstractFactory.Factories;

internal class AsanPardakhtTranscationFactory : ITransactionFactory
{
    public IFinancialTransaction CreateFinancialTransaction()
    {
        return new AsanPardakhtFinancialTransaction();
    }

    public IInformationalTransaction CreateInfomationalTransaction()
    {
        return new AsanPardakhtInformationalTransaction();
    }
}