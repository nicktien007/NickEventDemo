# NickEventDemo 說明
.Net 調用Event的方式
委託、事件與Observer設計模式

## NickEventDemo

- 原始版本
- 定義一個ProductFactory，生產Product
- 生產完畢 通知顯示器及監控裝置 顯示相關資訊(`ShowMsg`和`Display`)

## NickEventDemo.Iteration1

- 職責分離(SRP)
- 定義 Monitor、Screen 處理顯示資訊
- ProductFactory 專注生產 Product
- 使用Observer Design Pattern

### Observer 設計模式簡介

1. **Subject**：被監視對象，它往往包含著其他對象所感興趣的內容。在本範例中，`ProductFactory `就是一個監視對象，它包含的其他對象所感興趣的內容，當調用`CreateProduct`，會不斷把數據發給監視它的對象。
2. **Observer**：監視者，它監視Subject，當Subject中的某件事發生的時候，會告知Observer，而Observer則會採取相應的行動。在本範例中，Observer有`Monitor`和`Screen`，它們採取的行動分別是`ShowMsg`和`Display`。
3. GOF對它進行了抽象，稱為Observer設計模式：**Observer設計模式是為了定義對象間的一種一對多的依賴關係，以便於當一個對象的狀態改變時，其他依賴於它的對象會被自動告知並更新。Observer模式是一種鬆耦合的設計模式。**

### Iteration1 範例的順序

1. `Monitor`和`Screen`告訴`ProductFactory`，它們對它的`ProductName` 感興趣 => 註冊事件
2. `ProductFactory`保留`Monitor`和`Screen`的引用。
3. `ProductFactory`進生`CreateProduct`，並通過`Monitor`和`Screen`的引用，自動調用`Monitor.ShowMsg`、`Screen.Display`方法

## NickEventDemo.Iteration2

- 改寫符合 .Net Framework 的規範
- 也示範 泛型 EventHandler用法

### .Net Framework中的委派與事件
####  .Net Framework的事件 CodingStyle
- 委派類型的名稱都應該以`EventHandler`結束。
- 委派的原型定義：有一個void返回值，並接受兩個輸入參數：一個Object 類型，一個 `EventArgs`類型(或繼承自EventArgs)。
- 事件的命名為 委派去掉 `EventHandler`之後剩餘的部分。
- 繼承自EventArgs的類型應該以`EventArgs`結尾。

#### 補充說明
1. 委派聲明原型中的Object類型的參數代表了**Subject(被監視對象)**，在本例中是 **ProductFactory**。回調函數(比如ShowMsg的Display)可以通過它訪問觸發事件的對象(**ProductFactory**)
2. **EventArgs** 對象包含了Observer所感興趣的數據，在本例中是`ProductName`。