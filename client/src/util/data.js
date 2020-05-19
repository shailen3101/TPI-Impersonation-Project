export const commands = [
	{
		name: 'TPI_verifyPlayerSession',
		commandInfo: {
			commandDescrition:
				'This request is sent by the RGS to verify the information received in the launch URL and to collect further information about the player session from the iGP. ',
			paramterInfo: [],
		},
		paramaters: {
			brandId: '',
			skinId: '',
			gameId: '',
			channelType: '',
			presentType: '',
			secureToken: '',
			playerId: '',
			accountId: '',
			localeCode: '',
			currencyCode: '',
		},
	},
	{
		name: 'TPI_getPlayerBalance',
		commandInfo: {
			commandDescrition:
				'This request is sent by the RGS to obtain the current balances for a player account from the iGP. ',
			paramterInfo: [],
		},
		paramaters: { secureToken: '', playerId: '', accountId: '', brandId: '' },
	},
]
