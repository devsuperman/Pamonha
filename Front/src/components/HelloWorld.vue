<template>
  <div class="hello">
    <h1>Contador: {{ numeroDeVisitas }} </h1>
    <h2>Ambiente: {{ ambiente }} </h2>    
  </div>
</template>

<script>
export default {
  name: 'HelloWorld',
  data() {
    return {
      ambiente: '',
      numeroDeVisitas: '',
      nome: ''    
    }
  },
  created() {
    this.$resource('values')
      .get()
      .then(r => r.json())
      .then(r => {
        this.numeroDeVisitas = r.numeroDeVisitas;
        this.ambiente = r.ambiente;
      });    
  }  
}
</script>

<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
