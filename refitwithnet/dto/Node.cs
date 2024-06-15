using Refit;

namespace refitwithdotnet.node
{
    public interface INode
    {
        [Get("/node")]
        Task<IEnumerable<Node>> GetNodes();
    }

    public class Node
    {
        public string id { get; set; }
        public string name { get; set; }
        public string ip { get; set; }
        public int poolid { get; set; }
    }


}