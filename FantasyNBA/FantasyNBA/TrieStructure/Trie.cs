using FantasyNba.ApiConsumer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyNBA.TrieStructure
{
    class Tries
    {
        TrieNode root;

        public void CreateRoot()
        {
            root = new TrieNode();
        }

        public void Add(char[] chars, Playerentry _player)
        {
            TrieNode tempRoot = root;
            int total = chars.Count() - 1;
            for (int i = 0; i < chars.Count(); i++)
            {
                TrieNode newTrie;
                if (tempRoot.children.Keys.Contains(chars[i]))
                {
                    tempRoot = tempRoot.children[chars[i]];
                }
                else
                {
                    newTrie = new TrieNode();

                    if (total == i)
                    {
                        newTrie.endOfWord = true;
                        newTrie.Player = _player;
                    }

                    tempRoot.children.Add(chars[i], newTrie);
                    tempRoot = newTrie;
                }
            }
        }

        public bool FindPrefix(char[] chars)
        {
            TrieNode tempRoot = root;
            for (int i = 0; i < chars.Count(); i++)
            {
                if (tempRoot.children.Keys.Contains(chars[i]))
                {
                    tempRoot = tempRoot.children[chars[i]];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public Playerentry FindPlayer(char[] chars)
        {
            TrieNode tempRoot = root;
            int total = chars.Count() - 1;
            for (int i = 0; i < chars.Count(); i++)
            {
                if (tempRoot.children.Keys.Contains(chars[i]))
                {
                    tempRoot = tempRoot.children[chars[i]];

                    if (total == i)
                    {
                        if (tempRoot.endOfWord == true)
                        {
                            return tempRoot.Player;
                        }
                    }
                }
                else
                {
                    return tempRoot.Player;
                }
            }
            return tempRoot.Player;
        }
    }

    public class TrieNode
    {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public bool endOfWord;
        public Playerentry Player { get; set; }
    }
}