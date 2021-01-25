using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http;
using System.Linq;

namespace ErickService
{
    public class Program
    {
        private static Guild guild;
        private static IList<GuildMember> guildMembers;
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            await OnInitializedAsync();
        }

        

        protected static async Task OnInitializedAsync()
        {
            string uri = "guild-stats-2020-10-25 22.14.35.json";

            var http = new HttpClient();
            guild = await http.GetFromJsonAsync<Guild>(uri);

            await FilterMembers(guild.boxData);

            int code = 3;
        }


        protected static async Task FilterMembers(IList<Member> members)
        {
            guildMembers = new List<GuildMember>();

            foreach (var member in members)
            {
                if (guildMembers.Any(m => m.Name == member.PlayerName))
                {
                    await AddItemToGuildMember(member);
                }
                else
                {
                    await AddGuildMember(member);
                }
            }

        }

        protected static async Task AddItemToGuildMember(Member member)
        {
            var oldMember = guildMembers.FirstOrDefault(m => m.Name == member.PlayerName);

            oldMember.Items.Add(new BoxItem
            {
                Id = member.boxData.ItemID,
                Name = member.boxData.itemName,
                Rank = member.boxData.ItemRank,
                Count = member.boxData.Num
            });
        }

        protected static async Task AddGuildMember(Member member)
        {
            var newMember = new GuildMember
            {
                BoxName = member.boxName,
                Name = member.PlayerName
            };

            newMember.Items.Add(new BoxItem
            {
                Id = member.boxData.ItemID,
                Name = member.boxData.itemName,
                Rank = member.boxData.ItemRank,
                Count = member.boxData.Num
            });

            guildMembers.Add(newMember);
        }
    }


    


    public class GuildMember
    {
        public string Name { get; set; }
        public string BoxName { get; set; }
        public IList<BoxItem> Items { get; set; }

    }

    public class BoxItem
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }
    }

    public class Guild
    {
        public int IGG_ID { get; set; }
        public string guildDetail { get; set; }
        public long startDay { get; set; }
        public long startTime { get; set; }
        public long discardTime { get; set; }
        public bool isDiscard { get; set; }
        public StatInfo statInfo { get; set; }
        public IList<Member> boxData { get; set; }
    }

    public class StatInfo
    {
        public int helpSpent { get; set; }
        public int giftsCollectedTotal { get; set; }
        public IList<int> giftsCollected { get; set; }
    }

    public class Member
    {
        public int SN { get; set; }
        public int Status { get; set; }
        public long RcvTime { get; set; }
        public int BoxItemID { get; set; }
        public string PlayerName { get; set; }
        public bool isPurchase { get; set; }
        public int boxLevel { get; set; }
        public string boxName { get; set; }
        public Item boxData { get; set; }
    }

    public class Item
    {
        public int ItemID { get; set; }
        public int Num { get; set; }
        public int ItemRank { get; set; }
        public string itemName { get; set; }
    }

}
