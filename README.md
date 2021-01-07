#    設計模式 DesignPattern
本系列程式碼是依據「大話設計模式」內容進行C#的撰寫與學習。
依序說明6大設計原則與23種設計模式。


---

##    6大設計原則
###    單一職責原則 SRP
就一個類別而言，應該只有一個引起它變化的原因。

###    開放-封閉原則 OCP
開放封閉原則的意思是：對擴展開放，對修改關閉。在程式需要進行拓展的時候，不能去修改原有的程式碼，實現一個熱插拔的效果。簡言之，是為了使程式的擴展性好，易於維護和升級。

###    依賴倒轉原則
這個原則是開放封閉原則的基礎，具體內容：針對介面程式設計，依賴於抽象而不依賴於具體。

###    迪米特法則 LoD
一個實體應當盡量少地與其他實體之間發生相互作用，使得系統功能模組相對獨立。

###    里氏替換原則（Liskov Substitution Principle）
衍生類別（子類）物件可以在程式中代替其基礎類別（超類）物件。

###    合成聚合複用
盡量使用合成/聚合的方式，而不是使用繼承。


---

##    23種設計模式

###    1. 抽象工廠 (Abstract Factory)
提供一個建立一系列或相關依賴物件的介面，而無須指定他們具體的類別。
範例：

###    2. 建造者 (Builder)
將一個複雜物件的構建與它的表示分離，使得同樣的構建過程可以建立不同的表示。

###    3. 工廠方法 (Factory Method)
定義一個用於建立物件的介面，讓子類別決定實體化哪一個類別，工廠模式使一個類別的實體化延遲到旗子類別。

###    4. 原型 (Prototype)
用原型實體指定建立物件的種類，並且透過複製這些原型建立新的物件。

###    5. 獨體 (Singleton)
保證一個類別僅有一個實體，並提供一個存取它的全域存取點。

###    6. 轉接器 (Adapter)
將一個類別的見面轉換成客戶希望的另外一個介面。轉接器模式使得原本由於介面不相容，而不能一起工作的那些類別可以一起工作。

###    7. 橋接 (Bridge)
將抽象部分與它的實體部分分離，使它們都可以獨立地變化。

###    8. 組合 (Composite)
將物件組合成樹形結構以表示「部分-整體」的層次結構，組合模式使得用戶對單個物件和組合物件的使用具有一致性。

###    9. 裝飾 (Decorator)
動態的給一個類別添加額外的職責。就增加功能來說，裝飾模式相比產生子類別更為靈活。

###    10. 外觀 (Facade)
為子系統中的一組介面提供一個一致的介面，外觀模式定義了一個高層介面，這個介面使得這一子系統更加容易使用。

###    11. 享元 (Flyweight)
運用共享科技有效地支援大量細粒度的物件。

###    12. 代理 (Proxy)
為其他物件提供一種代理以控制對這個物件的訪問。

###    13. 觀察者 (Observer)
定義物件間的一種一對多的依賴關係，當一個物件的狀態發生改變時，所有依賴於它的物件都得到通知並被自動更新。

###    14. 範本方法 (TempleteMethod)
定義一個操作中的演演算法的骨架，而將一些步驟延遲到子類別中。樣板方法使得子類別可以不改變一個演演算法的結構即可重定義該演演算法的某些特定步驟。

###    15. 命令 (Command)
將一個請求封裝成一個物件，從而使您可以用不同的請求對客戶進行引數化。

###    16. 狀態 (State)
允許物件在內部狀態發生改變時改變它的行為，物件看起來好像修改了它的類。

###    17. 職責鏈 (Chain of Resposibility)
避免請求發送者與接收者耦合在一起，讓多個物件都有可能接收請求，將這些物件連接成一條鏈，並且沿著這條鏈傳遞請求，直到有物件處理它為止。

###    18. 解譯器 (Interpreter)
給定一個語言，定義它的文法表示，並定義一個直譯器，這個直譯器使用該標識來解釋語言中的句子。

###    19. 仲介者 (Mediator)
用一個中介物件來封裝一系列的物件互動，中介者使各物件不需要顯式地相互引用，從而使其耦合鬆散，而且可以獨立地改變它們之間的互動。

###    20. 訪問者 (Visitor)
主要將資料結構與資料操作分離。

###    21. 策略 (Strategy)
策略模式用策略的介面來替換在某個實體中的方法，可以經由替換不同的策略使得物件擁有不同的行為。經過策略的組合，我們得以獲得行為不同的物件。

###    22. 備忘錄 (Memento)
在不破壞封裝性的前提下，捕獲一個物件的內部狀態，並在該物件之外儲存這個狀態。

###    23. 迭代器 (Interator)
提供一種方法順序訪問一個聚合物件中各個元素, 而又無須暴露該物件的內部表示。
