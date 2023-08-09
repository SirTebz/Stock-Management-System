using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace Stock_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Welcome to a mock/simple Stock Management System using C#!
             * A stock management system is a software application that
             * helps businesses manage their inventory of goods.It allows businesses to track the flow of goods from
             * supplier to warehouse to customer and provides real-time information on the quantity and availability
             * of products. The system is designed to help businesses maintain optimal stock levels, reduce waste and
             * stockouts, and improve efficiency.It makes the tasks of adding and removing of stocks in inventory
             * simple. Stock manager can handle all these tasks on his fingertips. Overall, a stock management system
             * is an essential tool for businesses of all sizes that need to manage their inventory effectively and
             * efficiently.It can help businesses reduce costs, improve customer service, and increase profitability
             * by optimizing their supply chain and inventory management processes.*/

            Console.WriteLine("Welcome to a Stock Management System.");

            List <Stock> stocks = new List<Stock>();
            //ArrayList<Stock> stocks = new ArrayList<Stock>();

            int choice;
            do
            {
                Console.WriteLine("1. Add stock");
                Console.WriteLine("2. Remove stock");
                Console.WriteLine("3. View stock");
                Console.WriteLine("4. Exit\n");

                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter stock name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter stock quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        Console.Write("Enter stock price: ");
                        double price = double.Parse(Console.ReadLine());
                        Stock stock = new Stock(name, quantity, price);
                        stocks.Add(stock);
                        Console.WriteLine("Stock Added successfully.\n");
                        break;
                    case 2:
                        Console.Write("Enter the stock name: ");
                        string stockName = Console.ReadLine();
                        Console.Write("Enter the quantity to remove: ");
                        int removeQuantity = int.Parse(Console.ReadLine());
                        bool isStockFound = false;
                        foreach (Stock stockItem in stocks)
                        {
                            if (stockItem.GetName().Equals(stockName))
                            {
                                isStockFound = true;
                                stockItem.removeQuantity(removeQuantity);
                                Console.WriteLine("Stock Removed Successfully.\n");
                                break;
                            }
                        }
                        if (!isStockFound)
                        {
                            Console.WriteLine("Stock not found.\n");
                        }
                        break;
                    case 3:
                        Console.Write("Current stocks: ");
                        foreach (Stock item in stocks)
                        {
                            Console.WriteLine(item.toString());
                        }
                        break;
                    case 4:
                        Console.Write("Exiting program...\n");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again.\n");
                        break;
                }
            } while (choice != 4);
        }
    }
}
