using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiClass.Model.Entities
{
    public class Account
    {
        public Guid Id { get; set; }
       
        public string Number { get; set; }
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }//no value was specified for entity type balance in the table if no precision will cause the value to truncate
        public Guid CustomerId { get; set; }

        public virtual Customer Customer{ get; set; }

    }

    /*Microsoft.EntityFrameworkCore.Model.Validation[30000]
        No type was specified for the decimal property 'Balance' on entity type 'Account'. 
        This will cause values to be silently truncated if they do not fit in the default precision and scale.
        Explicitly specify the SQL server column type that can accommodate all the values in 'OnModelCreating' using 'HasColumnType()', 
        specify precision and scale using 'HasPrecision()' or configure a value converter using 'HasConversion()'.*/
}/*when i added the decimal annotation i got this: An operation was scaffolded that may result in the loss of data. Please review the migration for accuracy.
To undo this action, use Remove-Migration.*/