namespace Foaas.Client.Responses
{
    public class FoaasOperationsResponse
    {
        public Operation[] Operations { get; set; }

        public class Operation
        {
            public string Name { get; set; }
            public string Url { get; set; }
            public OperationField[] Fields { get; set; }
        }

        public class OperationField
        {
            public string Name { get; set; }
            public string Field { get; set; }
        }
    }
}
