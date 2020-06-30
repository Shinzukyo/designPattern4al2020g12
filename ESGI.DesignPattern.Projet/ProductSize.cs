using System;
using System.Collections.Generic;
using System.Text;

namespace ESGI.DesignPattern.Projet
{
    public interface IProductSize
    {
        public string Name { get; }
    }

    public class SmallSize : IProductSize
    {
        public string Name { get; } = "small";
    }

    public class MediumSize : IProductSize
    {
        public string Name { get; } = "medium";
    }

    public class LargeSize : IProductSize
    {
        public string Name { get; } = "large";
    }

    public class ExtraLargeSize : IProductSize
    {
        public string Name { get; } = "extra large";
    }

    public class NotApplicableSize : IProductSize
    {
        public string Name { get; } = "NOT APPLICABLE";
    }
}
