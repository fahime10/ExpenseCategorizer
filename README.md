# Expense Categorizer App
This application uses a trained model to output a predicted result from a given description.
In this scenario, the user needs to input something related to an expense, and the 
application will respond by defining the category.
For example, if the input is "Fanta", the application will output "Food".

## How to setup 
Download or clone the repository.
Open the project in Visual Studio Community. Ensure it is the latest version, which should contain
the machine learning options.
The model needs to be trained using the given dataset.
Double-click on "ExpenseCategorizerModel.mbconfig" and select "Data classification".
Then, choose the local environment for the training.
In the Data section, select the provided dataset, "expense_categorization_dataset.csv",
and then choose "Col1" as the column to predict.
In the Train section, input 60 seconds for the training time, then click on "Train".
Once trained, you may evaluate the model with some inputs like "Rent" or "House insurance".
The application should start working.

## Limitations
Although the dataset has 1070 records, it is relatively small and not exaustive. Some inputs may give the wrong prediction. This can be changed if more data is added in the dataset.