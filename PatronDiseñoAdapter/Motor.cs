using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronDiseñoAdapter
{
    public abstract class Motor
    {
        abstract public void encender();
        abstract public void acelerar();
        abstract public void apagar();
    }
}