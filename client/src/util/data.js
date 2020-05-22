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
	{
		name: 'TPI_startGameSession ',
		commandInfo: {
			commandDescrition:
				'This request is sent by the RGS to notify the iGP that a new Game Session has started for the player.',
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
			gameSessionId: 'f002e436-ce67-4f76-a41f-ee2b65c89e24',
			gameType: 'other',
			mfgCode: 'ABC',
			themeId: 'default theme',
			paytableId: 'defaultPaytable',
			releaseNum: '1.0',
			betConfigId: 'defaultBetConfig',
			jurisdictionCode: 'GB-ENG',
		},
	},
	{
		name: 'TPI_endGameSession',
		commandInfo: {
			commandDescrition:
				'This request is sent by the RGS to notify the iGP that a Game Session has ended for the player. ',
			paramterInfo: [],
		},
		paramaters: {
			secureToken: '',
			playerId: '',
			accountId: '',
			gameSessionId: '',
			gameSessionExc: 0,
			brandId: '',
			skinId: '',
			localeCode: '',
		},
	},
	{
		name: 'TPI_keepAlive',
		commandInfo: {
			commandDescrition:
				'This request is used by the RGS to prevent the iGP from terminating a Game Session due to inactivity. This should be called every 10 minutes while a Game Session is open if no other requests have been made for that Game Session. ',
			paramterInfo: [],
		},
		paramaters: {
			secureToken: '',
			playerId: '',
			accountId: '',
			gameSessionId: '',
		},
	},
]
