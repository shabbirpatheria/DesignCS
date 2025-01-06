// Coupling

using DesignCS.src.OopPrinciples.Coupling;
using DesignCS.src.OopPrinciples.Polymorphism;

var order = new Order(new SmsSender());
order.PlaceOrder();