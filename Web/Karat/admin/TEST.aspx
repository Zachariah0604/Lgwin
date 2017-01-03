<%@ Page Language="C#" AutoEventWireup="true" Inherits="Karat_admin_TEST" Codebehind="TEST.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="../javascript/teammembers.js" type="text/javascript"></script>
    <title></title>
</head>
<body >

<TABLE cellSpacing=0 cellPadding=0 width=772 align=center border=0>
  <TBODY>
    <TR>
    <TD class=b vAlign=top align=left width=764>

                      <form name=userinfo method=post >
                        <table width="80%" border="0" cellpadding="5" cellspacing="1" bgcolor="#CCCCCC" align="center">
                            <tr bgcolor="#FFFFFF">
                           
                            <td class=pad><select id="texttext" size="1" name="szSheng" onChange=chsel()>
									<option value="xxx" selected="selected">请选择部门</option>

                                        <option value="0" >站长</option>

                                        <option value="1" >综合部</option>

                                        <option value="2" >技术部(美工)</option>

                                        <option value="3" >技术部(程序)</option>
 

                                      </select>
                                      <select size="1" name="szShi">
                                        
                                        <option value="1" selected="selected">请选择职务</option>
	
                                      </select></td>
                          </tr>
                          </table>
                    </form>
  <script language=javascript src="js/floater.js"></script> 

</body>
</html>
