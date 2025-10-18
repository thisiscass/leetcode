function maxProfitDynamicPrograming(prices) {
    let i = 1;
    let solution = new Map();
    solution.set(0, 0);

    for (let k = 0; k < prices.length; k++) {
        while (i <= prices.length - 1) {
            let currentProfit = prices[i] - prices[k];
            let biggestProfit = solution.get(0)
            if(currentProfit > 0 && currentProfit > biggestProfit) {

                if(k > 0) {
                    let previousProfit = solution.get(k - 1) ?? 0;
                    if(previousProfit > biggestProfit) {
                        currentProfit = previousProfit;
                    }
                }

                solution.set(0, currentProfit);
            }   

            i++;
        }

        i = k + 1;

    }

    return solution.get(0);
};

function maxProfitOptimazed(prices) {
    let minPrice = prices[0];
    let maxProfit = 0;

    for(let i = 1; i < prices.length; i++) {
        const currentPrice = prices[i];
        let potentialProfit = currentPrice - minPrice;
        

        if(potentialProfit > maxProfit) {
            maxProfit = potentialProfit;
        } 
        
        if (currentPrice < minPrice) {
            minPrice = currentPrice;
        }
    }

    return maxProfit;
}

// let arr = [1,2]
// let arr = [7,6,4,3,1]
let arr = [7,1,5,3,6,4]

// console.log(maxProfitDynamicPrograming(arr));
console.log(maxProfitOptimazed(arr));