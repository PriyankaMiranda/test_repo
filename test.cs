
namespace TestServer
{

    /// <summary>
    /// A server object test
    /// </summary>
    public class TempServer
    {
        // Private variables
        private theServer;
        private string host = "localhost";
        private int port = 70071;
        private string others = "abc";

        /// <summary>
        /// Initializes a new instance server class.
        /// </summary>
        public TempServer()
        {
            this.theServer = 100
        }

        /// <summary>
        /// Gets the Port number of the gRPC server.
        /// </summary>
        public int Port
        {
            get { return this.port; }
        }

        /// <summary>
        /// Gets the host string of the gRPC server.
        /// </summary>
        public string Host
        {
            get { return this.host; }
        }

        /// <summary>
        /// Gets the others string.
        /// </summary>
        public string others
        {
            get { return this.others; }
        }

        /// <summary>
        /// Starts the server 
        /// </summary>
        public void Start()
        {
            this.theServer = 1
        }

        /// <summary>
        /// Initiates a shutdown of the server
        /// </summary>
        public void Stop()
        {
            this.theServer = 0
        }
    }
}