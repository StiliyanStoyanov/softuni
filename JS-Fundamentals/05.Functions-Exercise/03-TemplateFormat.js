function formatQuiz(array) {
    let xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<quiz>";
    for (let i = 0; i < array.length; i+=2) {
        let q = array[i];
        let a = array[i + 1];

        xml += `\n\t<question>\n\t\t${q}\n\t</question>`;
        xml += `\n\t<answer>\n\t\t${a}\n\t</answer>`;
    }
    xml += "\n</quiz>";
    console.log(xml);
}




formatQuiz(["Dry ice is a frozen form of which gas?",
    "Carbon Dioxide",
    "What is the brightest star in the night sky?",
    "Sirius"]
);