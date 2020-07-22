using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace TabbedBottomApp.Model
{
    public class Startuper
    {
        public string SturtuperName { get; set; }
        public string Topic { get; set; }
        public string ShortDescription { get; set; }
        public string ImageURL { get; set; }

        public List<Startuper> GetStartupers()
        {
            List<Startuper> sturtupers = new List<Startuper>()
            {
                new Startuper()
                {
                    SturtuperName="Хасанов Данил", Topic="DK PROJECT-RED", ImageURL="https://sun2.ufanet.userapi.com/qVmsI27M-G1PEe0NTgouL13dNQLidSUORHoy0g/DWYPmoKxLmc.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
                },

                new Startuper()
                {
                    SturtuperName="Александр Касьянов", Topic="Hololens DEVELOPMENT", ImageURL="https://sun2.ufanet.userapi.com/DL9_yK66Q2JgyYRpi8rU2vUB1r8mvFRUoEfIjQ/3GQeYO2gePA.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
                },
                new Startuper()
                {
                    SturtuperName="Данис Гатаулин", Topic="Skill Train", ImageURL="https://sun2.ufanet.userapi.com/uMT3HpciSu0ykSrezCVBoeL2VD81r6dEIG_SCQ/7gCNHLCaH74.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
                },
                new Startuper()
                {
                    SturtuperName="Айнур Мухтаров", Topic="SEKNAR SRIVINAS", ImageURL="https://sun9-14.userapi.com/c849032/v849032285/497ae/WLrzK-nlH7E.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."
                },
                  new Startuper()
                {
                    SturtuperName="Данис Гатаулин", Topic="Skill Train", ImageURL="https://sun2.ufanet.userapi.com/uMT3HpciSu0ykSrezCVBoeL2VD81r6dEIG_SCQ/7gCNHLCaH74.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
                },
                new Startuper()
                {
                    SturtuperName="Айнур Мухтаров", Topic="SEKNAR SRIVINAS", ImageURL="https://sun9-14.userapi.com/c849032/v849032285/497ae/WLrzK-nlH7E.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."
                },
                  new Startuper()
                {
                    SturtuperName="Данис Гатаулин", Topic="Skill Train", ImageURL="https://sun2.ufanet.userapi.com/uMT3HpciSu0ykSrezCVBoeL2VD81r6dEIG_SCQ/7gCNHLCaH74.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
                },
                new Startuper()
                {
                    SturtuperName="Айнур Мухтаров", Topic="SEKNAR SRIVINAS", ImageURL="https://sun9-14.userapi.com/c849032/v849032285/497ae/WLrzK-nlH7E.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."
                },
                  new Startuper()
                {
                    SturtuperName="Данис Гатаулин", Topic="Skill Train", ImageURL="https://sun2.ufanet.userapi.com/uMT3HpciSu0ykSrezCVBoeL2VD81r6dEIG_SCQ/7gCNHLCaH74.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
                },
                new Startuper()
                {
                    SturtuperName="Айнур Мухтаров", Topic="SEKNAR SRIVINAS", ImageURL="https://sun9-14.userapi.com/c849032/v849032285/497ae/WLrzK-nlH7E.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."
                },
                  new Startuper()
                {
                    SturtuperName="Данис Гатаулин", Topic="Skill Train", ImageURL="https://sun2.ufanet.userapi.com/uMT3HpciSu0ykSrezCVBoeL2VD81r6dEIG_SCQ/7gCNHLCaH74.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
                },
                new Startuper()
                {
                    SturtuperName="Айнур Мухтаров", Topic="SEKNAR SRIVINAS", ImageURL="https://sun9-14.userapi.com/c849032/v849032285/497ae/WLrzK-nlH7E.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."
                },
                  new Startuper()
                {
                    SturtuperName="Данис Гатаулин", Topic="Skill Train", ImageURL="https://sun2.ufanet.userapi.com/uMT3HpciSu0ykSrezCVBoeL2VD81r6dEIG_SCQ/7gCNHLCaH74.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
                },
                new Startuper()
                {
                    SturtuperName="Айнур Мухтаров", Topic="SEKNAR SRIVINAS", ImageURL="https://sun9-14.userapi.com/c849032/v849032285/497ae/WLrzK-nlH7E.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."
                },
                  new Startuper()
                {
                    SturtuperName="Данис Гатаулин", Topic="Skill Train", ImageURL="https://sun2.ufanet.userapi.com/uMT3HpciSu0ykSrezCVBoeL2VD81r6dEIG_SCQ/7gCNHLCaH74.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
                },
                new Startuper()
                {
                    SturtuperName="Айнур Мухтаров", Topic="SEKNAR SRIVINAS", ImageURL="https://sun9-14.userapi.com/c849032/v849032285/497ae/WLrzK-nlH7E.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."
                },
                  new Startuper()
                {
                    SturtuperName="Данис Гатаулин", Topic="Skill Train", ImageURL="https://sun2.ufanet.userapi.com/uMT3HpciSu0ykSrezCVBoeL2VD81r6dEIG_SCQ/7gCNHLCaH74.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
                },
                new Startuper()
                {
                    SturtuperName="Айнур Мухтаров", Topic="SEKNAR SRIVINAS", ImageURL="https://sun9-14.userapi.com/c849032/v849032285/497ae/WLrzK-nlH7E.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."
                },
                  new Startuper()
                {
                    SturtuperName="Данис Гатаулин", Topic="Skill Train", ImageURL="https://sun2.ufanet.userapi.com/uMT3HpciSu0ykSrezCVBoeL2VD81r6dEIG_SCQ/7gCNHLCaH74.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
                },
                new Startuper()
                {
                    SturtuperName="Айнур Мухтаров", Topic="SEKNAR SRIVINAS", ImageURL="https://sun9-14.userapi.com/c849032/v849032285/497ae/WLrzK-nlH7E.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."
                },
                  new Startuper()
                {
                    SturtuperName="Данис Гатаулин", Topic="Skill Train", ImageURL="https://sun2.ufanet.userapi.com/uMT3HpciSu0ykSrezCVBoeL2VD81r6dEIG_SCQ/7gCNHLCaH74.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"
                },
                new Startuper()
                {
                    SturtuperName="Айнур Мухтаров", Topic="SEKNAR SRIVINAS", ImageURL="https://sun9-14.userapi.com/c849032/v849032285/497ae/WLrzK-nlH7E.jpg",
                    ShortDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."
                }
            };
            return sturtupers;
        }

    }
}
