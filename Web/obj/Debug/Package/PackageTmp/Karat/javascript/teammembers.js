function IsDigit() {
    return ((event.keyCode >= 48) && (event.keyCode <= 57));
}

var selects = [];
selects['xxx'] = new Array(new Option('请选择职务', 'xxx'));

selects['0'] = new Array(

		new Option('站长', '1'));

selects['1'] = new Array(

		new Option('请选择职务', '1'),

		new Option('部长', '2'),

	    new Option('成员', '3'));

selects['2'] = new Array(

		new Option('请选择职务', '1'),

		new Option('部长', '2'),

	    new Option('成员', '3'));

selects['3'] = new Array(
		new Option('请选择职务', '1'),

		new Option('部长', '2'),

	    new Option('成员', '3'));

selects['4'] = new Array(
		new Option('请选择职务', '1'),

		new Option('部长', '2'),

	    new Option('成员', '3'));

function chsel() {
    with (document.userinfo) {
        if (szSheng.value) {
            szShi.options.length = 0;
            for (var i = 0; i < selects[szSheng.value].length; i++) {
                szShi.add(selects[szSheng.value][i]);
            }
        }
    }
}
