var storedType = 'Concept';

function setText(type) {
    if(storedType != type){
        document.getElementById('Title').innerHTML = type + " Generator";
        storedType = type
        document.getElementById('GenerationField').innerHTML = ""
    }
}

function generatePrompt() {
    if (storedType == 'Concept') {
        document.getElementById('GenerationField').innerHTML = storedType + " Prompt Placeholder."
    }
    else if (storedType == 'Sentence') {
        document.getElementById('GenerationField').innerHTML = storedType + " Prompt Placeholder."
    }
    else if (storedType == 'Setting') {
        document.getElementById('GenerationField').innerHTML = storedType + " Prompt Placeholder."
    }
    else if (storedType == 'Style') {
        document.getElementById('GenerationField').innerHTML = storedType + " Prompt Placeholder."
    }
    else {
        document.getElementById('GenerationField').innerHTML = storedType + " Prompt Placeholder."
    }
}

