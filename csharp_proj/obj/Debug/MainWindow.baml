   M S B A M L   `   `   `  ����F  Bcsharp_proj, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:csharp_projcsharp_proj  5   	       csharp_proj.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:csharp_proj     5   	     � Title$  
MainWindow��5   	   $��491.334��6   $��898.001��6-   $��Center=�6=   $��Center=�6Z    � 	Resources 5	       
  Color1��%+   &	        ��5
   
   	#FF62A17F��6*   5      .��5      � $��10,10,12.333,8.333q�6    J� RenderTransformOrigin$ 0.457,0.371&�6'   ���	#FF2493D2 � RowDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��89* �6    � ColumnDefinitions 5   
   �� 5      $	��17* �6   �� 5      $	��24* �6   �� 5      $
��617* �6   �� 5      $	��42* �6   �� 5      $��9* �6   �� 5      $
��119* �6   �� 5      $	��42* �6   .+�5   
   �� -   5         ��Name$ button��5      $'��!Зробити обрахунки��6!   $
��Left=�6=   $��1.667,253.333,0,0q�6X   $	��Top=�6s   $	��132��6�   $��2��6�   $��1��6�   $��20��6�   �� 5   
   -   5        $ button1��5      $��Додати ��6"   $
��Left=�64   $��
41,104,0,0q�6O   $	��Top=�6c   $	��120��6{   $��3��6�   $��1��6�   $��3��6�   $��20��6�   �� 5   
   -   5         ��Name$ label��5      $��Нове коло��6   $
��Left=�63   $��	40,19,0,0q�6N   $	��Top=�6a   $ 0.491,0.577&�6y   $��3��6�   $��3��6�   $��26��6�   $��68��6�   �� 5   
   -   5         ��Name$ r��5      $
��Left=�6   $��22��68   $��	40,68,0,0q�6D    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��120��6�   $��3��6�   $��1��6�   $��3��6�   �� 5   
   -   5        $ x��5      $
��Left=�6   $��22��68   $��	41,49,0,0q�6D   $
 Wrap=�6W   $	��Top=�6k   $	��119��6�   $��3��6�   $��3��6�   $��2��6�   �� 5   
   -   5        $ y��5      $
��Left=�6   $��23��68   $��	41,33,0,0q�6D   $
 Wrap=�6W   $	��Top=�6k   $	��119��6�   $��3��6�   $��1��6�   $��3��6�   �� 5    
   -   5        $ download��5       $��Відкрити файл��6#   $
��Left=�6;   $��23.667,4.333,0,0q�6V   $	��Top=�6p   $	��134��6�   $��1��6�   $��20��6�   $��2��6�   $��1��6�   �� 5!   
   -   5        $ label1��5!      $$��Робота з файлами��6    $
��Left=�6;   $	��Top=�6V   $��21.667,18,0,0q�6n   $��1��6�   $��26��6�   $	��110��6�   $��2��6�   �� 5"   
   -	   5        $
 save��5"      $��Зберегти файл��6   $
��Left=�67   $��23.667,33.333,0,0q�6R   $	��Top=�6m   $	��134��6�   $��1��6�   $��1��6�   $��21��6�   $��2��6�   �� 5#   
   -
   5        $ label3��5#      $>��8Максимум кіл, що перетинаються��6    $
��Left=�6I   $��22.667,139,0,0q�6d   $	��Top=�6|   $��24��6�   $	��201��6�   $��1��6�   $��1��6�   $��2��6�   �� 5$   
   -   5        $ textBox��5$      $
��Left=�6#   $��23��6>   $��1.667,168,0,0q�6J   $
 Wrap=�6a   $	��Top=�6u   $	��184��6�   	 J� IsHitTestVisible	 . 
 �� IsReadOnlyCaretVisible
 .  �� 
IsReadOnly . $��2��6�   $��1��6�   �� 5%   
   -   5        $ textBox1��5%      $
��Left=�6$   $��23��6?   $��1.667,214,0,0q�6K   $
 Wrap=�6b   $	��Top=�6v   $	��184��6�    . 
 . $��2��6�   $��1��6�   �� 5&   
   -   5        $ label4��5&      $?��9Кола, що знаходяться в кластері��6    $
��Left=�6J   $��20.667,190,0,0q�6e   $	��Top=�6}   $	��190��6�   $��1��6�   $��1��6�   $��26��6�   $ 0.5,0.5&�6�   $��2��6�   z�5'      V� 5(      .~�5)      �� �� 5*      �� 5+       �� Angle$ -0.455Q�6&   T� 5,      5-      5/      �� 50   
   -   5        $ button3��50      $ ��Видалити коло ��6"   $
��Left=�6;   $��0,331.333,0,0q�6V   $	��Top=�6m   $	��119��6�   $��4��6�   $��1��6�   $��2��6�   $��20��6�   �� 51   
   -   5        $ label5��51      $)��#Введіть номер кола ��6    $
��Left=�6>   $��38,144.333,0,0q�6Y   $	��Top=�6q   $��3��6�   $��1��6�   $��3��6�   $��26��6�   $	��121��6�   �� 52   
   -   5        $ textBox2��52      $
��Left=�6$   $��23��6?   $��
41,175,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   $��3��6�   $��1��6�   $��3��6�   �� 53   
   -   5        $ button4��53      $&�� Видалити всі кола��6"   $
��Left=�6>   $��23.667,103.333,0,0q�6Y   $	��Top=�6u   $	��134��6�   $��1��6�   $��1��6�   $��20��6�   $��2��6�   �� 54   
   -   5        $ button5��54      $,��&Зберегти як картинку��6"   $
��Left=�6A   $��23.667,68.333,0,0q�6\   $	��Top=�6w   $	��134��6�   $��1��6�   $��1��6�   $��20��6�   $��2��6�   �� 55   
   -   5        $ label6��55      $��r=��6    $
��Left=�6-   $��	15,62,0,0q�6H   $	��Top=�6[   $��3��6s   $��29��6�   $��1��6�   $��26��6�   $��2��6�   �� 56   
   $
��Left=�6   $	��410��60   $��208.667,12,0,0q�6=   $	��Top=�6U   $	��400��6m   $��2��6y   $��2��6�   {�.  4  .System.Windows.Automation.AutomationProperties   IsOffscreenBehavior$ Onscreen=�6�   .+�57      �� -   5         ��Name$ canvas1��57      $
��Left=�6&   $	��400��6A   $	��Top=�6N   $	��400��6f   $y�Visible=�6r   $ Onscreen=�6�   |�. }�. ��58      �� 59       �� ImageSource$ 	index.png��6!    j� Stretch$ Uniform=�69   5;      5<      �� 5=   
   -   5        $ button2��5=      $��Про програму��6"   $
��Left=�69   $��Bottom=�6T   $	��116��6o   $��20��6{   $��3.667,0,0,48q�6�   $��2��6�   $��1��6�   �� 5>   
   -   5        $ textBox4��5>      $
��Left=�6$   $��23��6?   $��
41,231,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   $��3��6�   $��1��6�   $��3��6�   6�   �� 5?   
   -   5        $ textBox5��5?      $
��Left=�6$   $��23��6?   $��
41,268,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   $��3��6�   $��1��6�   $��3��6�   �� 5@   
   -   5        $ button6��5@      $��Перемістити��6"   $
��Left=�68   $��	0,306,0,0q�6S   $	��Top=�6f   $	��119��6~   $��4��6�   $��1��6�   $��2��6�   $��20��6�   �� 5A   
   -   5        $ label7_Copy��5A      $��x=��6%   $
��Left=�62   $��
16,228,0,0q�6M   $	��Top=�6a   $��3��6y   $��25��6�   $��1��6�   $��26��6�   �� 5B   
   -   5        $ label8_Copy��5B      $	��y= ��6%   $
��Left=�63   $��
16,265,0,0q�6N   $	��Top=�6b   $��25��6z   $��3��6�   $��1��6�   $��26��6�   �� 5C   
   -   5        $ label2��5C      $#��Зміна координат��6    $��3��6:   $
��Left=�6J   $��38,204.333,0,0q�6e   $	��Top=�6}   $��1��6�   $��3��6�   $��27��6�   $	��103��6�   �� 5D   
   -   5        $ label7_Copy1��5D      $��x=��6&   $
��Left=�63   $��	15,49,0,0q�6N   $	��Top=�6a   $��3��6y   $��25��6�   $��26��6�   $��2��6�   �� 5E   
   -   5        $ label8_Copy1��5E      $	��y= ��6&   $
��Left=�64   $��	16,30,0,0q�6O   $	��Top=�6b   $��25��6z   $��3��6�   $��1��6�   $��26��6�   5H      5I      