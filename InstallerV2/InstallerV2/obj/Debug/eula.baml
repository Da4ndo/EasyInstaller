   M S B A M L   `   `   `  ����F  BInstallerV2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:InstallerV2InstallerV2  5          InstallerV2.eula   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:InstallerV2     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$
  eula��5      $	��646��5	      $	��433��5
       � 	Resources 5         IconButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value	 �� ImageSource  RoundCorner
 �Name ��Name �� CornerRadius �� 
TargetName��%I  &	        &	 y    �� 5   
   " ��6(   .�5      ��  � ��
 ���� 6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      � #��z��6   .+�5      �� 5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  � �� 5   &   �� 5   *   $)	 #/Resources/icons8_multiply_32px.png��65   5   #   5      5!      5#      5$      �� 5%   
   " ��6$   .�5&      ��  � ��$ Center=�6;   �� 5'       � ��$ Center=�69   �� 5(       � ��$ 1q�6(   �� 5)       � �� 5*      �� 5+      " ��6&   .R�5,      � $

 grid��6   .+�5-      �� $ border��5.   !   ���	#FFEFEFEF���	#FFBBBBBB$��1q�51   !   $ 8��52   !   ._�53   "   �� $��Center=�54   %   $��Center=�55   %   $��Normal"�56   %   57      59       5:      P� 5;       �@J�IsMouseOver . . �5<   "   �� $ border��6)    � �� �	#FF8E8D8D6T   5=      P� 5>       � {� .  . �5?   "   �� $
 grid��6)    �@J�Opacity$
 0.25Q�6N   5@      5C      5E      5F      5G      .��5H      � -   5        $	��646��5I   	   $	��433��5J   	   
������� � RowDefinitions 5M   
   �� 5N      $
��407* �6   �� 5O      $	��43* �6    � ColumnDefinitions 5Q   
   �� 5R      .+�5T   
   �� -   5         ��Name$ button_agree��5U      $��1��5V      $��73��5W      $��30��5X      $��	564,0,0,0q�5Y      $
��Left=�5Z      $��Center=�5[      $��Agree��5]      $��Arial)�5^      $��15(�5_      #���  5`      �� 5a   
   -   5        $ button_decline��5b      $��1��5c      $��73��5d      $��30��5e      $��0,0,85,0q�5f      $��Right=�5g      $��Center=�5h      $��Decline��5j      $��Arial)�5k      $��15(�5l      #���  5m      �� 5n   
   $	��580��5o      $	��360��5p      $��8q�5q      
���   �$��1q�5s      ._�5t      �� -   5         ��Name$ TextBlock_eula��5u      $	��560��5v      $	��340��5w      $��Center=�5x      $��Center=�5y      
�������$��Arial)�5{      $��13(�5|      $
��Wrap=�5}      5~      5      5�      