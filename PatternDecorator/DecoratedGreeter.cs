using Microsoft.Extensions.Logging;


namespace PatternDecorator
{
    class DecoratedGreeter : IGreeter
    {
        private readonly IGreeter decoratee;
        private readonly ILogger logger;

        public DecoratedGreeter(IGreeter decoratee, ILogger logger)
        {
            this.decoratee = decoratee;
            this.logger = logger;
        }

        public void Greet(string name)
        {
            logger.LogInformation("Greeted {0}", name);
            this.decoratee.Greet(name);
        }
    }
}
