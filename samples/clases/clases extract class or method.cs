//// Clases, extract clases, mantain SRP
// Mal
public class Receipt
{
    private List<decimal> aDiscounts;
    private List<decimal> aItemTotals;

    public Receipt()
    {
        aDiscounts = new List<decimal>();
        aItemTotals = new List<decimal>();
    }

    public decimal CalculateGrandTotal()
    {
        decimal nSubTotal = 0;
        decimal nTax;
        decimal nTotal;
        int nLenTotals = aItemTotals.Count;
        decimal nItemValue;
        decimal nDiscount;
        int nLenDiscounts = aDiscounts.Count;
        decimal nDiscountValue;

        for (nTotal = 0; nTotal < nLenTotals; nTotal++)
        {
            nItemValue = aItemTotals[(int)nTotal];
            nSubTotal += nItemValue;
        }

        if (nLenDiscounts > 0)
        {
            for (nDiscount = 0; nDiscount < nLenDiscounts; nDiscount++)
            {
                nDiscountValue = aDiscounts[(int)nDiscount];
                nSubTotal -= nDiscountValue;
            }
        }

        nTax = nSubTotal * 0.065m;
        nSubTotal += nTax;
        return nSubTotal;
    }
}

// Bien
public class Receipt
{
    private List<decimal> aDiscounts;
    private List<decimal> aItemTotals;

    public Receipt()
    {
        aDiscounts = new List<decimal>();
        aItemTotals = new List<decimal>();
    }

    public decimal CalculateGrandTotal()
    {
        decimal nSubTotal = CalculateSubtotal();
        nSubTotal = CalculateDiscounts(nSubTotal);
        nSubTotal = CalculateTax(nSubTotal);
        return nSubTotal;
    }

    private decimal CalculateTax(decimal nSubTotal)
    {
        decimal nTax = nSubTotal * 0.065m;
        nSubTotal += nTax;
        return nSubTotal;
    }

    private decimal CalculateDiscounts(decimal nSubTotal)
    {
        decimal nDiscount;
        int nLenDiscounts = aDiscounts.Count;
        decimal nDiscountValue;

        if (nLenDiscounts > 0)
        {
            for (nDiscount = 0; nDiscount < nLenDiscounts; nDiscount++)
            {
                nDiscountValue = aDiscounts[(int)nDiscount];
                nSubTotal -= nDiscountValue;
            }
        }

        return nSubTotal;
    }

    private decimal CalculateSubtotal()
    {
        decimal nSubTotal = 0;
        decimal nTotal;
        int nLenTotals = aItemTotals.Count;
        decimal nItemValue;

        for (nTotal = 0; nTotal < nLenTotals; nTotal++)
        {
            nItemValue = aItemTotals[(int)nTotal];
            nSubTotal += nItemValue;
        }

        return nSubTotal;
    }
}

// Mal
public class CustomerService
{
    public void CalculateOrderDiscount(List<Product> aProducts, Customer oCustomer)
    {
        // do work
    }

    public bool IsValidCustomer(Customer oCustomer, Order oOrder)
    {
        // do work
    }

    public List<string> GatherOrderErrors(List<Product> aProducts, Customer oCustomer)
    {
        // do work
    }

    public void Register(Customer oCustomer)
    {
        // do work
    }

    public void ForgotPassword(Customer oCustomer)
    {
        // do work
    }
}

// Bien
public class CustomerRegistrationService
{
    public void Register()
    {
        // do work
    }

    public void ForgotPassword()
    {
        // do work
    }
}

public class CustomerOrderService
{
    public void CalculateOrderDiscount(List<Product> aProducts, Customer oCustomer)
    {
        // do work
    }

    public bool IsValidCustomer(Customer oCustomer, Order oOrder)
    {
        // do work
    }

    public List<string> GatherOrderErrors(List<Product> aProducts, Customer oCustomer)
    {
        // do work
    }
}
