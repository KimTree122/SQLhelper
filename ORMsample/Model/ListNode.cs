using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMsample.Model
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }


    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyhead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyhead;
            int carry = 0;
            while (p != null || q != null)
            {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummyhead.next;
        }

        public string GetHint(string secret, string guess)
        {
            int bulls = 0 ,bullsw =0;
            int cows1 = 0, cows2 = 0;

            for (int i = 0; i < secret.Length; i++)
            {
                string s = secret.Substring(i, 1);
                
                for (int j = 0; j < guess.Length; j++)
                {
                    string g = guess.Substring(j, 1);
                    if (s == g) 
                    {
                        cows1++; break;
                    } 
                }
            }

            for (int i = 0; i < guess.Length; i++)
            {
                string g = guess.Substring(i, 1);
                for (int j = 0; j < secret.Length; j++)
                {
                    string s = secret.Substring(j, 1);
                    if (s == g)
                    {
                        cows2++; break;
                    } 
                }
            }

            int cows = Math.Min(cows1,cows2);

            bool c = cows == secret.Length ? true : false;

            for (int i = 0; i < secret.Length; i++)
            {
                string s = secret.Substring(i, 1);
                for (int j = 0; j < guess.Length; j++)
                {
                    string g = guess.Substring(j, 1);
                    if (s == g & i == j)
                    {
                        bulls++;
                        break;
                    }
                    if (s != g & i == j & c)
                    {
                        bullsw++;
                    }
                }
            }
            int cowcount =Math.Abs( cows - bulls-bullsw);
            return bulls + "A" + cowcount + "B";
        }

        private delegate string delgethit(string str1, string str2);

        public string GetHint2(string secret, string guess) 
        {

            List<string> sls = new List<string>();
            for (int i = 0; i < secret.Length; i++)
            {
                sls.Add(secret.Substring(i,1));
            }
            List<string> gls = new List<string>();
            for (int i = 0; i < guess.Length; i++)
            {
                gls.Add(guess.Substring(i,1));
            }

            int seccows = 0 , guescows = 0 ,cows = 0 , bulls = 0 , worbulls = 0;

            foreach (string secs in sls)
            {
                if (gls.Contains(secs)) seccows++;
            }

            foreach (string gues in gls)
            {
                if (sls.Contains(gues)) guescows++;
            }

            cows = Math.Min(seccows, guescows);

            bool c = cows == sls.Count ? true : false;

            List<string> correct = new List<string>();

            for (int i = 0; i < sls.Count; i++)
            {
                string s = sls[i];
                string g = gls[i];

                if (s == g)
                {
                    if (!correct.Contains(s))
                    {
                        bulls++;
                    }
                    else
                    {
                        bulls++;

                    }
                }

            }



            int cowcount = cows - bulls-worbulls;


            return bulls + "A" + cowcount + "B";
        }

    }

}
