using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shutta_test
{
    public class Player
    {
        public Player(int no) // 생성자로 호출시 몇번 플레이어인지 확인하기위함
        {
            No = no;
        }

        public int Money; // 보유하고 있는 돈
        public int No; // 몇번 플레이어인지 확인하기 위한 변수

        public List<Card> cards = new List<Card>(); // 카드를 받기 위한 List배열 변수

        // 카드를 받아와서 카드 List배열에 담는 메서드
        public void GetCard(Card card)
        {
            cards.Add(card);
        }        
    }
}