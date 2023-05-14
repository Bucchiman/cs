/*
 * FileName:     Program
 * Author:       8ucchiman
 * CreatedDate:  2023-05-11 21:28:08
 * LastModified: 2023-01-23 14:19:10 +0900
 * Reference:    https://www.techscore.com/tech/DesignPattern/Decorator
 * Description:  ---
 */


using System;


namespace HOGE{
    class GEHO{
        static void Main(string[] argv){
            
        }
    }

    public interface Icecream {
        public String getName();
        public String howSweet();
    }

    public class VanillaIcecream: Icecream {
        public String getName() {
            return "バニラアイスクリーム";
        }

        public String howSweet() {
            return "バニラ味";
        }
    }
    public class GreenTeaIcecream: Icecream{
	    public String getName() {
		    return "抹茶アイスクリーム";
	    }
	    public String howSweet(){
            return "抹茶味";
	    }
    }
    public class CashewNutsVanillaIcecream: VanillaIcecream {
        // VanillaIcecreamの継承
        // これだとバニラ味が固定となってしまいよくない
        public String getName() {
            // オーバーライド
            return "カシューナッツバニラアイスクリーム";
        }
    }

    public class CashewNutsToppingIcecream: Icecream {
        private Icecream ice = null;
        public CashewNutsToppingIcecream(Icecream ice) {
            this.ice = ice;
        }

        public String getName() {
            String name = "カシューナッツ";
            name += this.ice.getName();
            return name;
        }

        public String howSweet() {
            return this.ice.howSweet();
        }
    }
}

