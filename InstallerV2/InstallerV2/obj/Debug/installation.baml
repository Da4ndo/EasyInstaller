   M S B A M L   `   `   `  ����F  BInstallerV2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:InstallerV2InstallerV2  5          InstallerV2.installation   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6hc'https://handyorg.github.io/handycontrol     5      +localclr-namespace:InstallerV2     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  installation��5	      $	��646��5
      $	��433��5       � 	Resources 5         IconButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value	 �� ImageSource  RoundCorner
 �Name ��Name �� CornerRadius �� 
TargetName��%I  &	        &	 y    �� 5   
   " ��6(   .�5      ��  � ��
 ���� 6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      � #��z��6   .+�5      �� 5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  � �� 5   &   �� 5   *   $)	 #/Resources/icons8_multiply_32px.png��65   5   #   5       5"      5$      5%      �� 5&   
   " ��6$   .�5'      ��  � ��$ Center=�6;   �� 5(       � ��$ Center=�69   �� 5)       � ��$ 1q�6(   �� 5*       � �� 5+      �� 5,      " ��6&   .R�5-      � $

 grid��6   .+�5.      �� $ border��5/   !   ���	#FFEFEFEF���	#FFBBBBBB$��1q�52   !   $ 8��53   !   ._�54   "   �� $��Center=�55   %   $��Center=�56   %   $��Normal"�57   %   58      5:       5;      P� 5<       �@J�IsMouseOver . . �5=   "   �� $ border��6)    � �� �	#FF8E8D8D6T   5>      P� 5?       � {� .  . �5@   "   �� $
 grid��6)    �@J�Opacity$
 0.25Q�6N   5A      5D      5F      5G      5H      .��5I      � $	��646��5J   	   $	��433��5K   	   
������� � RowDefinitions 5M   
   �� 5N      $
��371* �6   �� 5O      $	��62* �6   .+�5Q   
   �� -   5         ��Name$ 
TextBlock1��5R      $	��626��5S      $��35��5T      $��	0,112,0,0q�5U      $��Center=�5V      $	��Top=�5W      $��Arial)�5X      $��14(�5Y      $(��"Waiting to press install button...��5Z       �� TextAlignment$ Center=�5[      $
��Wrap=�5\      �� 5]   
   -   5         ��Name$ button_install��5^      $��1��5_      $��73��5`      $��30��5a      $��
563,22,0,0q�5b      $
��Left=�5c      $	��Top=�5d      ���	#FF113C1E$��Install��5g      $��Arial)�5h      $��15(�5i      #���  5j      �� 5k   
   -   5        $ button_back��5l      $��1��5m      $��73��5n      $��30��5o      $��	10,22,0,0q�5p      $
��Left=�5q      $	��Top=�5r      $
��Back��5t      $��Arial)�5u      $��15(�5v      #���  5w      � 5x   
   -   5         �Name$ progressBar��5y      $	��400��5z      $��18��5{      $��0,0,0,0q�5|      $��Center=�5}      $��Center=�5~      ���	#FFF3F3F35      �� 5�   
   -   5        $ progressBar_Percentage��5�      $��56��5�      $��18��5�      $��0,0,60,0q�5�      $��Right=�5�      $��Center=�5�      $��Arial)�5�      $��15(�5�      $��0%��5�      $
��Wrap=�5�      5�      5�      