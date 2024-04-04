# Description
There is a free public API, it is called **Numbers API**. It has multiple endpoints, one of which returns a random fact about any date of a year.

The base code is given. The program takes a month number and a day number from the user.

**Task:** Make a request to the Numbers API to retrieve a random fact about that date.

**Guidelines:**
The <code>url</code> at which you make a request will depend upon the date which the user enters. It means that the URL will not be fixed, rather, it would follow a format. You can read about the format of this API at the [Numbers API website](http://numbersapi.com/).

The format of retrieving a fact about some date is: `http://numbersapi.com/<month>/<day>/date` where `<month>` represents the number of the month and `<day>` represents the number of the day. For-example, if the user enters `11` for the month (which represents the 11th month - November) and `6` for the day,  the URL will be: `http://numbersapi.com/11/6/date`

**Steps:**
- Create a new variable called `url` and store the url following the format explained in Guidelines. You might need to use string formatting;
- Create a new `HttpClient()` object;
- Use the `HttpClient` object and make a `GET` request to the `url`;
- Store the response of the HTTP request into a `HttpResponseMessage` object;
- Extract the raw message text from the `HttpResponseMessage` object using `ReadAsStringAsync` method;
- Display the message;

**Note:** This task does not have unit tests. You can verify the correctness of your code based on a successful response from the API.

### Hints
> 1. You can make an HTTP request using an `HttpClient` object;
> 2. The response of the HTTP request can be stored in an `HttpResponseMessage` object;
