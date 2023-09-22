

<p align="center">
  <img src="https://i.ibb.co/zs0cDZP/Main.png">  
</p>


## Overview:
<p align="center">
FileCloaker transforms any filetype (e.g. .zip, .exe, .xls, etc.) into a list of harmless-looking strings in a txt file. This lets you hide the file in plain sight, and transfer the file without triggering alerts. The fancy term for this is "text-based steganography", hiding data by making it look like other data. For example, you can transform a .zip file into a list of Automobiles names or MD5 hashes. You then transfer the cloaked file however you choose, and then decloak the exfiltrated file back into its original form.
<p align="center">
With your payload cloaked, you can transfer data across a secure network’s perimeter without triggering alerts. You can also defeat data whitelisting controls - is there a security device that only allows IP addresses to leave or enter a network? Turn your payload into IP addresses, problem solved. Additionaly, you can derail the security analyst’s review via social engineering attacks against their workflows. And as a final bonus, cloaked files defeat signature-based malware detection tools.
</p>
<p align="center">
The pre-packaged ciphers are designed to appear like harmless / ignorable lists, though some (like MD5 password hashes) are specifically meant as distracting bait.
</p>
<p align="center">
FileCloaker is also a great way to introduce people to crypto and steganography concepts. It's simple to use, guides the user through the process, and according to our kids is also fun!
</p>

## Features:

 - Can cloak any type of file
 - Added encryption to precompiled ciphers
 - Creates Meta data file so you can remember from which cipher you cloak the file 
 - Create own cipher with predifiend encryption key


## Cloaking Screen:

<p align="center">
  <img src="https://i.ibb.co/SrmxPbb/Cloak.png">  
</p>
<p align="center">

## DeCloaking Screen:
<p align="center">
  <img src="https://i.ibb.co/K9CjDxq/Decloaker.png">  
</p>
<p align="center">


## CHANGE ENCRYPTION KEY:
- Goto FileCloaker/FileCloaker/Functions/Functions.cs  
```
public string EnKey()
        {
            return Varsx.CiphersEncryptionKey = "MAKV2SPBNI99212";// All precompiled ciphers are encrypted with this key be carefull when change this to your own!
        }
```

 
 ## DEVELOPERS & CREDIT:
 
 - Developer  [**Mrfr05t**](https://github.com/mrfr05t) ( I did nothing actually! :D )
 - Programmer  [**Omnimaverick**](https://github.com/Omnimaverick)
 - Joe Gervais (TryCatchHCF)
 for developing  [**CloakifyFactory**](https://github.com/TryCatchHCF/Cloakify) 

 
 ## Disclaimer:
**This tool is supposed to be used only on authorized systems. Any unauthorized use of this tool without explicit permission is illegal.**

## License:
 [**GNU GENERAL PUBLIC LICENSE**](https://github.com/mrfr05t/FileCloaker/blob/master/LICENSE.txt) 
 
 
