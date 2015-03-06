open System
open System.Windows.Forms
// open elosnoc000.modCsv

module AgeTest =
    type Person = { Name: string; Age: int}

    let testData = 
        [| 
            {Name = "Joe"; Age = 37};
            {Name = "Julie"; Age = 35}
        |] 


let form = new Form (Text = "F# Win Form")
let dataGrid = new DataGridView(Dock=DockStyle.Fill, DataSource = AgeTest.testData)
form.Controls.Add(dataGrid)
Application.Run(form)


[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    // let xoxo = System.Console.ReadLine()

    0 // return an integer exit code


