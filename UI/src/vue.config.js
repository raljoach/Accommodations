module.exports = {
  chainWebpack: config => {
    config.externals({
      chance: 'chance',
	  numeral: 'numeral',
	  lodash: 'lodash'
    })
  }
}