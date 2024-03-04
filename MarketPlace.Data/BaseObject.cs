using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace MarketPlace.Data
{
    public class BaseObject
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? LastModified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public string IPAddress { get; set; } = IPAddressUtil.GetLocalIPAddress();

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }

    public static class IPAddressUtil
    {
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}