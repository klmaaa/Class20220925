using static System.Console;

class DemoLoan
{
    static void Main()
    {
        Loan aLoan = new Loan();
        aLoan.LoanNumber = 2239;
        aLoan.LastName = "Mitchell";
        aLoan.LoanAmount = 1_000.00;
        WriteLine("Loan #{0} for {1} is for {2}", aLoan.LoanNumber, aLoan.LastName, aLoan.LoanAmount.ToString("C2"));

        CarLoan aCarLoan = new CarLoan();
        aCarLoan.LoanNumber = 3358;
        aCarLoan.LastName = "Jansen";
        aCarLoan.LoanAmount = 20_000.00;
        aCarLoan.Make = "Ford";
        aCarLoan.Year = 2007;
        WriteLine("Loan #{0} for {1} is for {2}", aCarLoan.LoanNumber, aCarLoan.LastName,
            aCarLoan.LoanAmount.ToString("C2"));
        WriteLine(" Loan #{0} is for a {1} {2}",
            aCarLoan.LoanNumber, aCarLoan.Year,
            aCarLoan.Make);
    }
}

class Loan
{
    public int LoanNumber { get; set; }
    public string LastName { get; set; }
    public double LoanAmount { get; set; }

}

class CarLoan : Loan
{
    public int Year { get; set; }
    public string Make { get; set; }
}