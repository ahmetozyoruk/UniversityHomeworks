   M S B A M L   `   `   `  ����A  =Target, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TargetTarget  5   	       Target.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Target     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value   MyEmployeeData � XPath �� DataType �� ItemsSource �� XPath��%�  'Q�       '�� n     &	  �     (�� �    5&   #   *EmployeeInfo+)�� 5
   
   " Q�6   .�5      ��  � ��
 ��  �6+   �� 5       � ��$ 12(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 80��6&   �� 5       �@��TextWrapping$
 Wrap=�6-   5      � 5   
   $ /EmployeeData��61   .��5      ��<EmployeeData xmlns="">
                    <EmployeeInfo>
                        <EmployeeInfoData>Employee1</EmployeeInfoData>
                        <Item Type="FirstName">Jesper</Item>
                        <Item Type="LastName">Aaberg</Item>
                        <Item Type="EmployeeNumber">12345</Item>
                    </EmployeeInfo>
                    <EmployeeInfo>
                        <EmployeeInfoData>Employee2</EmployeeInfoData>
                        <Item Type="FirstName">Dominik</Item>
                        <Item Type="LastName">Paiha</Item>
                        <Item Type="EmployeeNumber">98765</Item>
                    </EmployeeInfo>
                </EmployeeData>        5$      �� 5&   
   $ EmployeeInfo��6#    5'      �� $
 Item��.R�5(      �� ��6   �� $ EmployeeInfoData��5)      5+      .��5,      �� .+�5-   
   �� QOTreeView control with TreeViewItem content explicitly defined as Header strings5/   $   R� 50   
   .@�51      Q� $��	Employee1��6   .@�52      Q� $��Jesper��6   Q� 53      $��Aaberg��6   Q� 54      $��12345��6   55      Q� 56      $��	Employee2��6   .@�57      Q� $��Dominik��6   Q� 58      $��Paiha��6   Q� 59      $��98765��6   5:      5;      �� 5=   
   FDTreeView control with leaf nodes specified as Items that are Buttons5@      R� 5A   
   .@�5B      Q� $��	Employee1��6   @�5C      �� 5D      -   5        .��5D   -   Jesper65   �� 5E      -   5        .��5E   -   Aaberg65   �� 5F      -   5        .��5F   -   1234564   5H      Q� 5I      $��	Employee2��6   @�5J      �� 5K      -   5        .��5K   -   	Dominik66   �� 5L      -   5        .��5L   -   Paiha64   �� 5M      -   5        .��5M   -   9876564   5O      5P      �� 5Q   
   `^TreeView control with root nodes defined as Buttons and and leaf nodes that are Header strings5U      R� 5V   
   .@�5W      Q� ��5X      �� 5Y      -   5        .��5Y   -   	Employee168   .@�5[      Q� $��Jesper��6   Q� 5\      $��Aaberg��6   Q� 5]      $��12345��6   5^      Q� 5_      ��5`      �� 5a      -   5        .��5a   -   	Employee268   .@�5c      Q� $��Dominik��6   Q� 5d      $��Paiha��6   Q� 5e      $��98765��6   5f      5g      �� 5h   
   fdTreeView control created by databinding with an XMLDataProvider and using a HierarchicalDataTemplate5l      R� 5m   
   ��6   �� 	 �� Source#	 [  $ EmployeeInfo���� 5o   
   caTreeView control whose Items contain DockPanel controls with embedded Image and TextBlock content5r      R� 5s   
   .@�5t      Q� $��Animals��6   @�5u      ]� 5v      .+�5w      �� $��data\fish.png��6    �� 5x      $��5q�6$   
���**��$��12(�5y      Fish6,   5z      ]� 5{      .+�5|      �� $��data\dog.png��6    �� 5}      $��5q�6$   
���**��$��12(�5~      Dog6+   5      ]� 5�      .+�5�      �� $��data\cat.png��6    �� 5�      $��5q�6$   
���**��$��12(�5�      Cat6+   5�      5�      5�      5�      5�      