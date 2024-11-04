using System;

namespace BankOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 100;

            // Вычисление процентов
            (balance, double bankProfit) = InterestCalculation(50, balance);
            Console.WriteLine($"Баланс после снятия: {balance}, прибыль банка: {bankProfit}");

            // Удаление суммы из баланса
            balance = DepositWithdrawal(50, balance);
            Console.WriteLine($"Баланс после вклада: {balance}");

            // Проверка одобрения кредита
            string loanStatus = LoanApproval(balance);
            Console.WriteLine(loanStatus);

            // Расчёт сложных процентов
            double initialAmount = 1000; // начальная сумма
            double annualRate = 5;        // годовая процентная ставка в процентах
            int years = 10;               // количество лет

            double finalAmount = CalculateCompoundInterest(initialAmount, annualRate, years);
            Console.WriteLine($"Конечная сумма после {years} лет: {finalAmount}");
        }

        static string LoanApproval(double balance)
        {
            if (balance <= 0)
            {
                return "Кредит одобрен!";
            }
            else
            {
                return "У вас достаточно средств, кредит не нужен.";
            }
        }

        static (double, double) InterestCalculation(double amountToWithdraw, double balance)
        {
            double interest = amountToWithdraw * 0.05;
            double newBalance = balance - interest;
            double bankProfit = interest;
            return (newBalance, bankProfit);
        }

        static double DepositWithdrawal(double deposit, double balance)
        {
            return balance - deposit;
        }

        static double CalculateCompoundInterest(double principal, double annualRate, int years)
        {
            double rate = annualRate / 100; // преобразуем процент в десятичный формат
            double finalAmount = principal * Math.Pow((1 + rate), years);
            return finalAmount;
        }
    }
}
