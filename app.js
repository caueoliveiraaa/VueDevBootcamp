// View model
const vm = Vue.createApp({
    data() {
        return {
            firstName: 'John',
            lastName: 'Smith'
        }
    },
    methods: {
        fullName() {
            return `${this.firstName}, ${this.lastName}`
        }
    }
}).mount('#app')

setTimeout(() => {
    vm.firstName = 'Bob'
}, 2000)

// Vue.createApp({
//     data() {
//         return {
//             firstName:'Bryan',
//             lastName:'Wade'
//         }
//     }
// }).mount('#app2')
