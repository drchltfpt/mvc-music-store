
function getSession() {
    var someSession = '<%= Session["SessionName"].ToString() %>';
    if (someSession === null) {
        $('#session').appendChild('<a> href="#">Sign In</a>')
    } 
}

getSession();


//alert(someSession)