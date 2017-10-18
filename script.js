var storedType = 'Concept';

//Sets which type of prompt to generate, also changes the display name of the prompt generator field.
//
//params: type (The type of prompt you wish to generate.)
function setText(type) {
    if (storedType != type) {
        $('#info').remove();
        document.getElementById('Title').innerHTML = type + " Generator";
        storedType = type
        document.getElementById('GenerationField').innerHTML = ""
    }
    // A special case because of the extra field needed for this prompt. (Input for the number of chain generated sentences.)
    if (type == "Chain") {
        $('#info').remove();
        $(".buttonRow").append("<input type='text', name='Enter Number', id='info', value='Input number of sentences'>");
    }
    else {
        $('#info').remove();
    }
}
//Generates the prompts. These are simply placeholders for now in their semi-proper formats.
//
//params: NA
function generatePrompt() {
    if (storedType == 'Concept') {
        document.getElementById('GenerationField').innerHTML = storedType + " Prompt Placeholder."
    }
    else if (storedType == 'Sentence') {
        document.getElementById('GenerationField').innerHTML = storedType + " Prompt Placeholder."
    }
    //Generates the number of sentences given, up to a max of 5. If a number is not entered, or an invalid value (such as a string), nothing happens.
    else if (storedType == 'Chain') {
        var i2 = document.getElementById("info").value;
        $('.chainList').remove();
        $(".GenerationField").append("<ol, class='chainList'></ol>");
        var i = 0;
        while(i < i2 && i < 5){
            $(".chainList").append("<li>Chain Prompt Placeholder.</li>");
            i++;
        }
    }
    else if (storedType == 'Setting') {
        document.getElementById('GenerationField').innerHTML = storedType + " Prompt Placeholder."
    }
    else if (storedType == 'Style') {
        document.getElementById('GenerationField').innerHTML = storedType + " Prompt Placeholder."
    }
    //Another special case that generates a table with character details. (Once again though, for now it simply holds placeholder values.)
    else {
        $('.Character').remove();
        $(".GenerationField").append("<table style='width:100%', class='Character'><tr><th>First</th><th>Lastname</th><th>Age</th><th>Profession</th></tr ><tr><td>NA</td><td>NA</td><td>NA</td><td>NA</td></tr></table>");
    }
}

