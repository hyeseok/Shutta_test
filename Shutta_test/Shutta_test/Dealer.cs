﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shutta_test
{
    public class Dealer
    {
        private List<Card> cards = new List<Card>(); // 카드를 받아와서 List배열에 담기
        private List<int> kwangNumbers = new List<int> { 1, 3, 8 };
        // isKwang이라는 List배열에 {1,3,8}을 담아 1,8광땡 / 3,8광땡을 표현하기 위함

        // 카드 섞기 구현
        public void ShuffleCard()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Card card = new Card();
                    card.number = i + 1;
                    card.isKwang = false;
                }
            }
        }

        // 카드 1장씩 나눠주기
    }
}