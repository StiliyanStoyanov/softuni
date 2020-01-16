function onlineShop(selector) {
    let form = `<div id="header">Online Shop Inventory</div>
    <div class="block">
        <label class="field">Product details:</label>
        <br>
        <input placeholder="Enter product" class="custom-select">
        <input class="input1" id="price" type="number" min="1" max="999999" value="1"><label class="text">BGN</label>
        <input class="input1" id="quantity" type="number" min="1" value="1"><label class="text">Qty.</label>
        <button id="submit" class="button" disabled>Submit</button>
        <br><br>
        <label class="field">Inventory:</label>
        <br>
        <ul class="display">
        </ul>
        <br>
        <label class="field">Capacity:</label><input id="capacity" readonly>
        <label class="field">(maximum capacity is 150 items.)</label>
        <br>
        <label class="field">Price:</label><input id="sum" readonly>
        <label class="field">BGN</label>
    </div>`;
    $(selector).html(form);
    // Write your code here
    $(document).ready(function () {
        $('.custom-select').on('input change', function () {
            if ($(this).val() != '') {
                $('#submit').prop('disabled', false);
            }
            else {
                $('#submit').prop('disabled', true);
            }
        });
    });
    let submitButton = $('#submit');
    let takeProduct = $('.custom-select');
    let takePrice = $('#price');
    let takeQuantity = $('#quantity');
    let takeCapacity = $('#capacity');
    let sum = $('#sum');
    let inventory = $('.display')
    let capacity = takeCapacity.val();
    submitButton.on('click', function () {
        let product = takeProduct.val();
        let price = takePrice.val();
        let quantity = takeQuantity.val();
        takeProduct.val('');
        takeQuantity.val(1);
        takePrice.val(1);
        let li = $(`<li>Product: ${product} Price: ${price} Quantity: ${quantity}</li>`)
        inventory.append(li);
        let sumTotal = Number(sum.val()) + (Number(price));
        sum.val(sumTotal);
        $('#submit').prop('disabled', true);
        let totalQuantity = Number(capacity) + Number(quantity);
        takeCapacity.val(totalQuantity);
        capacity = takeCapacity.val();
        if (capacity >= 150) {
            takeCapacity.val('full')
            takeCapacity.addClass('fullCapacity')
        }
    });
}
