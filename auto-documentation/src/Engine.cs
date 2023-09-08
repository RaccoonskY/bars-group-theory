using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_documentation.Source
{
    /// <summary>
    /// This is supposed to be just
    /// well documented class. It does nothing.
    /// </summary>
    public class Engine <T>
        where T : class,IEnumerable, new()
    {

        /// <value>
        /// represent the name of engine
        /// </value>
        public string Name { get; set; }

        /// <value>
        /// represent the description of engine
        /// </value>
        public string Description { get; set; }

        /// <value>
        /// The enumerable collection to store various objects
        /// </value>
        public T EnumerableValue;


        /// <summary>
        /// class Engine constructor with no arguments
        /// </summary>
        /// <returns>
        /// An instance of Engine object.
        /// </returns>
        public Engine() { 
        
        }


        /// <summary>
        /// class Engine constructor with  arguments
        /// </summary>
        /// <returns>
        /// An instance of Engine object with 
        /// <paramref name="name"/> and <paramref name="Description"/> initialized.
        /// </returns>
        /// <param name="name">represents name of engine instance</param>
        /// <param name="description">represents description of engine instance</param>
        public Engine(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }


        /// <summary>
        /// This method is supposed to throw exception
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// If <see cref="Name"/> is null or empty exception occures.
        /// </exception>
        public void MethodThrowsException() 
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("Name");
            }
        }


        /// <inheritdoc/>
        /// <summary>
        /// Method to get string representation of object
        /// </summary>
        /// <returns>
        /// String representation of object consisting of <see cref="Name"/> 
        /// and <see cref="Description"/> data
        /// </returns>
        /// <example>
        ///     <c>
        ///     Console.WriteLine(engine.ToString());
        ///     </c>
        /// </example>
        public override string ToString()
        {
           return $"{Name}: {Description}";
        }
    }
}
