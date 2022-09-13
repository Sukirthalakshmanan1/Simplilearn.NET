using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movieslib
{
    public interface ICommand
    {
        #region Methods

        void Execute();

        #endregion Methods
    }

    public interface IPriceFactory
    {
        #region Methods

        PriceBase CreatePrice(int priceCode);

        #endregion Methods
    }

    public class ChildrenMoviePrice : PriceBase
    {
        #region Constructors

        public ChildrenMoviePrice(int priceCode)
            : base(priceCode)
        {
        }

        #endregion Constructors

        #region Methods

        public override double getAmount(int daysRented)
        {
            double thisAmount = 1.5;
            if (daysRented > 3)
                thisAmount += (daysRented - 3) * 1.5;
            return thisAmount;
        }

        #endregion Methods
    }

    public class CommandEngine
    {
        #region Fields

        private List<ICommand> _commands = new List<ICommand>();

        #endregion Fields

        #region Methods

        public void Add(ICommand command)
        {
            _commands.Add(command);
        }

        public void Run()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        #endregion Methods
    }

    public class CreateCustomerCommand : ICommand
    {
        #region Fields

        private readonly string _customerName;
        private readonly CustomerStore _customerStore;

        #endregion Fields

        #region Constructors

        public CreateCustomerCommand(CustomerStore customerStore, string customerName)
        {
            _customerStore = customerStore;
            _customerName = customerName;
        }

        #endregion Constructors

        #region Methods

        public void Execute()
        {
            var customer = new Customer(_customerName);
            _customerStore.Add(customer);
        }

        #endregion Methods
    }

    public class Customer
    {
        #region Fields

        private String _name;
        private List<Rental> _rentals = new List<Rental>();

        #endregion Fields

        #region Constructors

        public Customer(String name)
        {
            _name = name;
        }

        #endregion Constructors

        #region Methods

        public void addRental(Rental arg)
        {
            _rentals.Add(arg);
        }

        public String getName()
        {
            return _name;
        }

        public String statement()
        {
            String result = "Rental Record for " + getName() + "\n";
            foreach (var rental in _rentals)
            {
                //show figures for this rental
                result += "\t" + rental.getMovie().Title + "\t" + rental.getAmount() + "\n";
            }
            //add footer lines
            result += "Amount owed is " + getTotalAmount() + "\n";
            result += "You earned " + getTotalFrequentRenterPoints() + " frequent renter points";
            return result;
        }

        private double getTotalAmount()
        {
            double totalAmount = 0;
            foreach (var rental in _rentals)
            {
                totalAmount += rental.getAmount();
            }
            return totalAmount;
        }

        private int getTotalFrequentRenterPoints()
        {
            int frequentRenterPoints = 0;
            foreach (var rental in _rentals)
            {
                // add frequent renter points
                frequentRenterPoints += rental.getFrequentRenterPoints();
            }
            return frequentRenterPoints;
        }

        #endregion Methods
    }

    public class CustomerStore
    {
        #region Fields

        private List<Customer> _list = new List<Customer>();

        #endregion Fields

        #region Methods

        public void Add(Customer customer)
        {
            _list.Add(customer);
        }

        public Customer Get(string name)
        {
            return _list.FirstOrDefault(c => c.getName() == name);
        }

        #endregion Methods
    }

    public class Movie
    {
        #region Fields

        public const int CHILDRENS = 2;
        public const int NEW_RELEASE = 1;
        public const int REGULAR = 0;

        private readonly IPriceFactory _priceFactory;

        private PriceBase _price;
        private int _priceCode;
        private string _title;

        #endregion Fields

        #region Constructors

        public Movie(String title, int priceCode, IPriceFactory priceFactory)
        {
            _title = title;
            _priceFactory = priceFactory;
            setPrice(priceCode);
        }

        #endregion Constructors

        #region Properties

        public int PriceCode
        {
            get { return _price.getPriceCode(); }
            set { setPrice(value); }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        #endregion Properties

        #region Methods

        public double getAmount(int daysRented)
        {
            return _price.getAmount(daysRented);
        }

        public int getFrequentRenterPoints(int daysRented)
        {
            int frequentRenterPoints = 1;
            // add bonus for a two day new release rental
            if ((this.PriceCode == Movie.NEW_RELEASE) && daysRented > 1) ++frequentRenterPoints;
            return frequentRenterPoints;
        }

        private void setPrice(int priceCode)
        {
            this._price = _priceFactory.CreatePrice(priceCode);
        }

        #endregion Methods
    }

    public class NewMoviePrice : PriceBase
    {
        #region Constructors

        public NewMoviePrice(int priceCode)
            : base(priceCode)
        {
        }

        #endregion Constructors

        #region Methods

        public override double getAmount(int daysRented)
        {
            return daysRented * 3;
        }

        #endregion Methods
    }

    public abstract class PriceBase
    {
        #region Fields

        private readonly int _priceCode;

        #endregion Fields

        #region Constructors

        protected PriceBase(int priceCode)
        {
            _priceCode = priceCode;
        }

        #endregion Constructors

        #region Methods

        public abstract double getAmount(int daysRented);

        public int getPriceCode()
        {
            return _priceCode;
        }

        #endregion Methods
    }

    public class PriceFactory : IPriceFactory
    {
        #region Methods

        public PriceBase CreatePrice(int priceCode)
        {
            PriceBase _price = null;
            switch (priceCode)
            {
                case 2:
                    _price = new ChildrenMoviePrice(priceCode);
                    break;
                case 1:
                    _price = new NewMoviePrice(priceCode);
                    break;
                case 0:
                    _price = new RegularMoviePrice(priceCode);
                    break;
            }
            return _price;
        }

        #endregion Methods
    }

    public class RegularMoviePrice : PriceBase
    {
        #region Constructors

        public RegularMoviePrice(int priceCode)
            : base(priceCode)
        {
        }

        #endregion Constructors

        #region Methods

        public override double getAmount(int daysRented)
        {
            double thisAmount = 2;
            if (daysRented > 2)
                thisAmount += (daysRented - 2) * 1.5;
            return thisAmount;
        }

        #endregion Methods
    }

    public class Rental
    {
        #region Fields

        private int _daysRented;
        private Movie _movie;

        #endregion Fields

        #region Constructors

        public Rental(Movie movie, int daysRented)
        {
            _movie = movie;
            _daysRented = daysRented;
        }

        #endregion Constructors

        #region Methods

        public double getAmount()
        {
            return getMovie().getAmount(this.getDaysRented());
        }

        public int getDaysRented()
        {
            return _daysRented;
        }

        public int getFrequentRenterPoints()
        {
            return getMovie().getFrequentRenterPoints(this.getDaysRented());
        }

        public Movie getMovie()
        {
            return _movie;
        }

        #endregion Methods
    }

}
