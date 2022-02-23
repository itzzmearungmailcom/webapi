using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webapi20220212.Controllers
{
    [RoutePrefix("prods")]
    public class ProductController : ApiController
    {
        // GET: api/Product
        [Route("")]
        [AcceptVerbs("GET", "VIEW")]
        [Route("~/rp")]
        public string GetAllProducts()
        {



            string input = "addfnfjtlknke";
            string cha = "";
            string output = "";
            foreach (var item in input.ToCharArray())
            {

                //output+= input.Contains(item.ToString()) ? !output.Contains(item) ? item.ToString() : "" : "";
            }


            return output;
        }

        // GET: api/Product/5
        //[HttpGet, Route("account/{account:validateAccounts}")]
        [HttpGet, Route("{account}")]
        public string GetProduct(string account)
        {
            //string cha = "";
            //string output = "";
            //foreach (var item in account.ToCharArray())
            //{
            //    if (cha.IndexOf(item)==-1)
            //    {
            //        cha += item;
            //        output += item;
            //    }
            //    //output+= input.Contains(item.ToString()) ? !output.Contains(item) ? item.ToString() : "" : "";
            //}
            // Store encountered letters in this string.
            string table = "";

            // Store the result in this string.
            string result = "";

            // Loop over each character.
            foreach (char value in account)
            {
                // See if character is in the table.
                if (table.IndexOf(value) == -1)
                {
                    // Append to the table and the result.
                    table += value;
                    result += value;
                }
            }
            return result + " " + table;
        }

        [HttpGet, Route("{id}/{prod}")]
        public string Get(int id, string prod)
        {
            return "values";

        }
        // POST: api/Product
        [HttpPost]
        public void CreateProducts([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }

        [HttpGet, Route("ana/{a}/{b}")]
        public bool CheckAnagrams(string a, string b)
        {
            string ch = "";
            char[] aa = a.ToCharArray();
            char[] bb = b.ToCharArray();
            Array.Sort(aa);
            Array.Sort(bb);
            string aaa = new string(aa);
            string bbb = new string(bb);
            var x = aaa == bbb ? true : false;


            return x;
        }
        [HttpGet, Route("reverse")]
        public string ReverseStr(string s)
        {

            string ss = "";
            //char[] s = s.ToCharArray();
            for (int i = 1; i <= s.Length; i++)
            {
                ss += s[s.Length - i];
            }
            return ss;
        }

        [HttpGet, Route("CountWords")]
        public int CountWords(string s)
        {
            string[] ss = s.Split(' ');
            return ss.Length;
        }

        [HttpGet, Route("HighestCount")]
        public char HighestCount(string s)
        {
            char cc = ' ';
            int max = -1;
            int[] count = new int[256];
            for (int i = 0; i < s.Length; i++)
                count[s[i]]++;

            for (int i = 0; i < s.Length; i++)
            {
                int co = count[s[i]];

                    if (max< count[s[i]])
                    {
                    max = count[s[i]];
                        cc = s[i];
                            
                        
                    }
                
            }
            return cc;
        }

        [Route("unique")]
        public bool UniqueCheck(string s)
        {
            string newStr = "";

            foreach (var item in s)
            {
                if (newStr.Contains(item))
                {
                    return false;
                }
                else
                {
                    newStr += item;
                }

            }
            return true;
        }
        
    }
}
