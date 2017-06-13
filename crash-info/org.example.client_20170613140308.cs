S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 16525
Date: 2017-06-13 14:03:08+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 4
      (SIGILL)
      si_code: 1
      illegal opcode
      si_addr: 0xb277164e

Register Information
r0   = 0xb88d3c38, r1   = 0xb88cfb70
r2   = 0xb88cfb70, r3   = 0xb88d3c38
r4   = 0xb3f60a3c, r5   = 0xbee2a484
r6   = 0x00000001, r7   = 0xbee2a348
r8   = 0xbee2a478, r9   = 0xb87293f0
r10  = 0xbee2a498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbee2a2ec
lr   = 0xb27715d5, pc   = 0xb277164e
cpsr = 0x40070030

Memory Information
MemTotal:   987012 KB
MemFree:     68604 KB
Buffers:     62504 KB
Cached:     228844 KB
VmPeak:      98668 KB
VmSize:      98664 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19560 KB
VmRSS:       19560 KB
VmData:      30212 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35772 KB
VmPTE:          74 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 16525 TID = 16525
16525 16529 16541 16542 

Maps Information
b1322000 b132a000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b133c000 b1b3b000 rw-p [stack:16542]
b1b3b000 b1b3c000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b4c000 b1b60000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b74000 b1b75000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b85000 b1b88000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b99000 b1b9a000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1baa000 b1bac000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bbc000 b1bbe000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bce000 b1bde000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bee000 b1bfa000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c0c000 b240b000 rw-p [stack:16541]
b273c000 b2743000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2756000 b275c000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b276c000 b279c000 r-xp /opt/usr/apps/org.example.client/bin/client
b28e5000 b29c8000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29ff000 b2a27000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a39000 b3238000 rw-p [stack:16529]
b3238000 b323a000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b324a000 b3254000 r-xp /lib/libnss_files-2.20-2014.11.so
b3265000 b326e000 r-xp /lib/libnss_nis-2.20-2014.11.so
b327f000 b3290000 r-xp /lib/libnsl-2.20-2014.11.so
b32a3000 b32a9000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32ba000 b32bb000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32e3000 b32ea000 r-xp /usr/lib/libminizip.so.1.0.0
b32fa000 b32ff000 r-xp /usr/lib/libstorage.so.0.1
b330f000 b336e000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3384000 b3398000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33a8000 b33ec000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33fc000 b3404000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3414000 b3444000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3457000 b3510000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3524000 b3577000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3588000 b35a3000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35b3000 b3674000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3687000 b3697000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36a7000 b36b4000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36c5000 b36cc000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36dc000 b371d000 r-xp /usr/lib/libmdm.so.1.2.12
b372d000 b3735000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3744000 b3754000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3775000 b37d5000 r-xp /usr/lib/libasound.so.2.0.0
b37e7000 b37ea000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37fa000 b37fd000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b380d000 b3812000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3822000 b3823000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3833000 b383e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3852000 b3859000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3869000 b386f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b387f000 b3884000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3894000 b38af000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38bf000 b38c6000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38d6000 b38d9000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38ea000 b3918000 r-xp /usr/lib/libidn.so.11.5.44
b3928000 b393e000 r-xp /usr/lib/libnghttp2.so.5.4.0
b394f000 b3959000 r-xp /usr/lib/libcares.so.2.1.0
b3969000 b3973000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3983000 b3985000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3995000 b3996000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39a6000 b39aa000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39bb000 b39e3000 r-xp /usr/lib/libui-extension.so.0.1.0
b39f4000 b3a1d000 r-xp /usr/lib/libturbojpeg.so
b3a3d000 b3a43000 r-xp /usr/lib/libgif.so.4.1.6
b3a53000 b3a99000 r-xp /usr/lib/libcurl.so.4.3.0
b3aaa000 b3acb000 r-xp /usr/lib/libexif.so.12.3.3
b3ae6000 b3afb000 r-xp /usr/lib/libtts.so
b3b0c000 b3b14000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b24000 b3bea000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c0a000 b3d02000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d21000 b3def000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e06000 b3e08000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e18000 b3e1e000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e2e000 b3e51000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e62000 b3e64000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e74000 b3e76000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e87000 b3e8c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ea3000 b3ea5000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3eb5000 b3ebc000 r-xp /usr/lib/libsensord-share.so
b3ecc000 b3ee4000 r-xp /usr/lib/libsensor.so.1.1.0
b3ef5000 b3ef8000 r-xp /usr/lib/libXv.so.1.0.0
b3f08000 b3f0d000 r-xp /usr/lib/libutilX.so.1.1.0
b3f1d000 b3f22000 r-xp /usr/lib/libappcore-common.so.1.1
b3f32000 b3f39000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f4c000 b3f50000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f61000 b403f000 r-xp /usr/lib/libCOREGL.so.4.0
b405f000 b4062000 r-xp /usr/lib/libuuid.so.1.3.0
b4072000 b4089000 r-xp /usr/lib/libblkid.so.1.1.0
b409a000 b409c000 r-xp /usr/lib/libXau.so.6.0.0
b40ac000 b40f3000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4105000 b410b000 r-xp /usr/lib/libjson-c.so.2.0.1
b411c000 b4120000 r-xp /usr/lib/libogg.so.0.7.1
b4130000 b4152000 r-xp /usr/lib/libvorbis.so.0.4.3
b4162000 b4246000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4262000 b4265000 r-xp /usr/lib/libEGL.so.1.4
b4276000 b427c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b428c000 b428e000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b429e000 b42ab000 r-xp /usr/lib/libGLESv2.so.2.0
b42bc000 b431e000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4333000 b434b000 r-xp /usr/lib/libmount.so.1.1.0
b435d000 b4371000 r-xp /usr/lib/libxcb.so.1.1.0
b4381000 b4388000 r-xp /lib/libcrypt-2.20-2014.11.so
b43c0000 b43c2000 r-xp /usr/lib/libiri.so
b43d2000 b43dd000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43ee000 b4424000 r-xp /usr/lib/libpulse.so.0.16.2
b4435000 b4478000 r-xp /usr/lib/libsndfile.so.1.0.25
b448d000 b44a2000 r-xp /lib/libexpat.so.1.5.2
b44b4000 b4572000 r-xp /usr/lib/libcairo.so.2.11200.14
b4586000 b458e000 r-xp /usr/lib/libdrm.so.2.4.0
b459e000 b45a1000 r-xp /usr/lib/libdri2.so.0.0.0
b45b1000 b45ff000 r-xp /usr/lib/libssl.so.1.0.0
b4614000 b4620000 r-xp /usr/lib/libeeze.so.1.13.0
b4631000 b463a000 r-xp /usr/lib/libethumb.so.1.13.0
b464a000 b464d000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b465d000 b4814000 r-xp /usr/lib/libcrypto.so.1.0.0
b55ff000 b5608000 r-xp /usr/lib/libXi.so.6.1.0
b5618000 b561a000 r-xp /usr/lib/libXgesture.so.7.0.0
b562a000 b562e000 r-xp /usr/lib/libXtst.so.6.1.0
b563e000 b5644000 r-xp /usr/lib/libXrender.so.1.3.0
b5654000 b565a000 r-xp /usr/lib/libXrandr.so.2.2.0
b566a000 b566c000 r-xp /usr/lib/libXinerama.so.1.0.0
b567d000 b5680000 r-xp /usr/lib/libXfixes.so.3.1.0
b5690000 b569b000 r-xp /usr/lib/libXext.so.6.4.0
b56ab000 b56ad000 r-xp /usr/lib/libXdamage.so.1.1.0
b56bd000 b56bf000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56cf000 b57b1000 r-xp /usr/lib/libX11.so.6.3.0
b57c5000 b57cc000 r-xp /usr/lib/libXcursor.so.1.0.2
b57dc000 b57f4000 r-xp /usr/lib/libudev.so.1.6.0
b57f6000 b57f9000 r-xp /lib/libattr.so.1.1.0
b5809000 b5829000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b582a000 b582f000 r-xp /usr/lib/libffi.so.6.0.2
b5840000 b5858000 r-xp /lib/libz.so.1.2.8
b5868000 b586a000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b587a000 b594f000 r-xp /usr/lib/libxml2.so.2.9.2
b5964000 b59ff000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a1b000 b5a1e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a2e000 b5a47000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a58000 b5a69000 r-xp /lib/libresolv-2.20-2014.11.so
b5a7d000 b5af7000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b0c000 b5b0e000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b1e000 b5b25000 r-xp /usr/lib/libembryo.so.1.13.0
b5b35000 b5b3f000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b50000 b5b68000 r-xp /usr/lib/libpng12.so.0.50.0
b5b79000 b5b9c000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bbd000 b5bd1000 r-xp /usr/lib/libector.so.1.13.0
b5be2000 b5bfa000 r-xp /usr/lib/liblua-5.1.so
b5c0b000 b5c62000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c76000 b5c9e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5caf000 b5cc2000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cd3000 b5d0d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d1e000 b5d2c000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d3c000 b5d44000 r-xp /usr/lib/libtbm.so.1.0.0
b5d54000 b5d61000 r-xp /usr/lib/libeio.so.1.13.0
b5d71000 b5d73000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d83000 b5d88000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d98000 b5daf000 r-xp /usr/lib/libefreet.so.1.13.0
b5dc1000 b5de1000 r-xp /usr/lib/libeldbus.so.1.13.0
b5df1000 b5e11000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e13000 b5e19000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e29000 b5e3a000 r-xp /usr/lib/libemotion.so.1.13.0
b5e4b000 b5e52000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e62000 b5e71000 r-xp /usr/lib/libeo.so.1.13.0
b5e82000 b5e94000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ea5000 b5eaa000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eba000 b5ed3000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ee3000 b5f00000 r-xp /usr/lib/libeet.so.1.13.0
b5f19000 b5f61000 r-xp /usr/lib/libeina.so.1.13.0
b5f72000 b5f82000 r-xp /usr/lib/libefl.so.1.13.0
b5f93000 b6078000 r-xp /usr/lib/libicuuc.so.51.1
b6095000 b61d5000 r-xp /usr/lib/libicui18n.so.51.1
b61ec000 b6224000 r-xp /usr/lib/libecore_x.so.1.13.0
b6236000 b6239000 r-xp /lib/libcap.so.2.21
b6249000 b6272000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6283000 b628a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b629c000 b62d3000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62e4000 b63cf000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63e2000 b645b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b646d000 b6472000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6482000 b648c000 r-xp /usr/lib/libvconf.so.0.2.45
b649c000 b649e000 r-xp /usr/lib/libvasum.so.0.3.1
b64ae000 b64b0000 r-xp /usr/lib/libttrace.so.1.1
b64c0000 b64c3000 r-xp /usr/lib/libiniparser.so.0
b64d3000 b64f9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6509000 b650e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b651f000 b6536000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6547000 b65b2000 r-xp /lib/libm-2.20-2014.11.so
b65c3000 b65c9000 r-xp /lib/librt-2.20-2014.11.so
b65da000 b65e7000 r-xp /usr/lib/libunwind.so.8.0.1
b661d000 b6741000 r-xp /lib/libc-2.20-2014.11.so
b6756000 b676f000 r-xp /lib/libgcc_s-4.9.so.1
b677f000 b6861000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6872000 b689c000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68ad000 b68e9000 r-xp /usr/lib/libsystemd.so.0.4.0
b68eb000 b696e000 r-xp /usr/lib/libedje.so.1.13.0
b6981000 b699f000 r-xp /usr/lib/libecore.so.1.13.0
b69bf000 b6b46000 r-xp /usr/lib/libevas.so.1.13.0
b6b7b000 b6b8f000 r-xp /lib/libpthread-2.20-2014.11.so
b6ba3000 b6dd7000 r-xp /usr/lib/libelementary.so.1.13.0
b6e06000 b6e0a000 r-xp /usr/lib/libsmack.so.1.0.0
b6e1a000 b6e21000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e31000 b6e33000 r-xp /usr/lib/libdlog.so.0.0.0
b6e43000 b6e46000 r-xp /usr/lib/libbundle.so.0.1.22
b6e56000 b6e58000 r-xp /lib/libdl-2.20-2014.11.so
b6e69000 b6e81000 r-xp /usr/lib/libaul.so.0.1.0
b6e95000 b6e9a000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eab000 b6eb8000 r-xp /usr/lib/liblptcp.so
b6eca000 b6ece000 r-xp /usr/lib/libsys-assert.so
b6edf000 b6eff000 r-xp /lib/ld-2.20-2014.11.so
b6f10000 b6f15000 r-xp /usr/bin/launchpad-loader
b86bb000 b8900000 rw-p [heap]
bee0a000 bee2b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16525)
Call Stack Count: 13
 0: $d.51 + 0x0 (0xb277164e) [/opt/usr/apps/org.example.client/bin/client] + 0x564e
 1: _ZN7MyLoginC2EP9Naviframe + 0x84 (0xb27715d5) [/opt/usr/apps/org.example.client/bin/client] + 0x55d5
 2: _ZN8MyWindow8onCreateEv + 0x118 (0xb27713a9) [/opt/usr/apps/org.example.client/bin/client] + 0x53a9
 3: _ZN6Window10app_createEPv + 0x72 (0xb278a5cf) [/opt/usr/apps/org.example.client/bin/client] + 0x1e5cf
 4: _ZN6Window17static_app_createEPv + 0x24 (0xb278a745) [/opt/usr/apps/org.example.client/bin/client] + 0x1e745
 5: (0xb3f4e4f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 6: appcore_efl_main + 0x152 (0xb6e98203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 7: ui_app_main + 0xc0 (0xb3f4e909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
 8: _ZN6Window10makeWindowEiPPc + 0x11e (0xb278aacf) [/opt/usr/apps/org.example.client/bin/client] + 0x1eacf
 9: main + 0x40 (0xb2771129) [/opt/usr/apps/org.example.client/bin/client] + 0x5129
10: (0xb6f11bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
11: __libc_start_main + 0x114 (0xb66334bc) [/lib/libc.so.6] + 0x164bc
12: (0xb6f11eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
reate(641) > app_appcore_create
06-13 14:03:08.010+0900 E/TBM     (16525): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:03:08.060+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 16525, appid: org.example.client
06-13 14:03:08.060+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:03:08.060+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(425) > request cmd(1) result(16525)
06-13 14:03:08.240+0900 W/CRASH_MANAGER(16473): worker.c: worker_job(1199) > 0416489636c691497330184
06-13 14:03:08.501+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17174715
06-13 14:03:08.501+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17174715
06-13 14:03:08.501+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 14:03:08.501+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 14:03:08.501+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 14:03:08.801+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:03:08.801+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:03:08.801+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:03:08.801+0900 E/STARTER (  721): )
06-13 14:03:08.811+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:03:08.811+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:03:08.811+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:03:08.811+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 14:03:08.811+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:03:08.821+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 14:03:08.821+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:03:08.821+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 14:03:08.821+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:03:08.831+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:03:08.831+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:03:08.851+0900 I/GXT_SIB (  342): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:03:08.851+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bdc6e9 in class 'Edje_Object'.
06-13 14:03:08.851+0900 E/UXT     (  342): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
06-13 14:03:08.981+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:08.991+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:09.011+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:09.031+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:09.041+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:09.061+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:09.081+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:09.091+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:09.101+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 16525 pgid = 16525
06-13 14:03:09.101+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(16525)
06-13 14:03:09.101+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 16525.
06-13 14:03:09.111+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1653
06-13 14:03:09.111+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:09.131+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:09.141+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:03:09.141+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:03:09.141+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:03:09.141+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:03:09.141+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:03:09.141+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: MEM_FLUSH State: PAUSED
06-13 14:03:09.141+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:09.151+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 16525.
06-13 14:03:09.151+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 16525
06-13 14:03:09.151+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1654
06-13 14:03:09.161+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:09.171+0900 E/CAPI_APPFW_APPLICATION(16205): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:03:09.171+0900 E/CAPI_APPFW_APPLICATION(16205): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:03:09.171+0900 E/CAPI_APPFW_APPLICATION(16205): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:03:09.171+0900 E/CAPI_APPFW_APPLICATION(16205): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:03:09.171+0900 E/CAPI_APPFW_APPLICATION(16205): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:03:09.171+0900 I/CAPI_APPFW_APPLICATION(16205): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:03:09.171+0900 I/CAPI_APPFW_APPLICATION(16205): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:03:09.181+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:09.191+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:09.241+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 16205, appid: com.samsung.task-mgr
06-13 14:03:09.241+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:03:09.241+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(16205)
06-13 14:03:09.241+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 14:03:09.261+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16525
06-13 14:03:09.261+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 16525
06-13 14:03:09.331+0900 W/TASK_MGR_LITE(16205): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 14:03:09.331+0900 I/GXT_SIB (16205): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:03:09.371+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:03:09.371+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:03:09.391+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17175593
06-13 14:03:09.391+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 14:03:09.391+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 14:03:09.391+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17175593
06-13 14:03:09.391+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:03:09.391+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:03:09.391+0900 E/STARTER (  721): )
06-13 14:03:09.391+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:03:09.391+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:03:09.402+0900 E/RUA     (16205): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 24, ncols : 5
06-13 14:03:09.402+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:03:09.412+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 14:03:09.412+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 14:03:09.412+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:03:09.412+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:03:09.412+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:03:09.412+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:03:09.412+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:03:09.442+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:03:09.492+0900 I/APP_CORE(16205): appcore-efl.c: __do_app(514) > [APP 16205] Event: RESET State: CREATED
06-13 14:03:09.492+0900 I/CAPI_APPFW_APPLICATION(16205): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 14:03:09.492+0900 E/EFL     (16205): edje<16205> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:03:09.492+0900 E/EFL     (16205): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:03:09.492+0900 E/EFL     (16205): edje<16205> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:03:09.492+0900 E/EFL     (16205): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:03:09.492+0900 W/APP_CORE(16205): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3200003
06-13 14:03:09.492+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 14:03:09.612+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(16205) status(0)
06-13 14:03:09.612+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(16205) status(0)
06-13 14:03:09.612+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 14:03:09.612+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:03:09.612+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 14:03:09.612+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 14:03:09.612+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 14:03:09.612+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 14:03:09.622+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(16205) status(3)
06-13 14:03:09.622+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:03:09.622+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:03:09.622+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(16205)
06-13 14:03:09.622+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 16205, appid: com.samsung.task-mgr, status: fg
06-13 14:03:09.622+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:09.632+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 14:03:09.632+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:03:09.632+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:03:09.632+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 14:03:09.642+0900 I/APP_CORE(16205): appcore-efl.c: __do_app(514) > [APP 16205] Event: RESUME State: CREATED
06-13 14:03:09.652+0900 I/APP_CORE(16205): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 14:03:09.652+0900 I/APP_CORE(16205): appcore-efl.c: __do_app(625) > [APP 16205] Initial Launching, call the resume_cb
06-13 14:03:09.652+0900 I/CAPI_APPFW_APPLICATION(16205): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:03:09.692+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:03:10.092+0900 I/UXT     (16577): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:03:10.152+0900 E/EFL     (16205): ecore_x<16205> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17176361
06-13 14:03:10.152+0900 E/TASK_MGR_LITE(16205): recent_app_viewer.c: on_item_mouse_move(863) > mouse hasn't been pressed!
06-13 14:03:10.292+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 14:03:10.292+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 16205.
06-13 14:03:10.463+0900 E/EFL     (16205): ecore_x<16205> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17176672
06-13 14:03:10.763+0900 I/CAPI_APPFW_APPLICATION(16205): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:03:10.763+0900 W/TASK_MGR_LITE(16205): task-mgr-lite.c: _pause_app(406) > 
06-13 14:03:10.763+0900 I/CAPI_APPFW_APPLICATION(16205): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:03:10.763+0900 E/TASK_MGR_LITE(16205): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 14:03:10.763+0900 E/EFL     (16205): eo<16205> lib/eo/eo_ptr_indirection.x:295 _eo_obj_pointer_get() eo_id 0x8004120b's acvie is  NULL, entry: 0xb33a6068, 0xb7849948, 0
06-13 14:03:10.763+0900 E/EFL     (16205): eo<16205> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0x8004120b is not pointing to a valid object. Maybe it has already been freed.
06-13 14:03:10.763+0900 E/EFL     (16205): eo<16205> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x8004120b) is an invalid ref.
06-13 14:03:10.773+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:03:10.773+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:03:10.773+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(16205)
06-13 14:03:10.773+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 16205, appid: com.samsung.task-mgr, status: bg
06-13 14:03:10.783+0900 E/TASK_MGR_LITE(16205): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 14:03:10.783+0900 E/APP_CORE(16205): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 14:03:10.793+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:03:10.793+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:03:10.793+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:03:10.793+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:03:10.793+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:03:10.793+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:03:10.833+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:03:10.853+0900 I/MALI    (16205): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=16205   close drm_fd=30 
06-13 14:03:10.883+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:03:10.883+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:03:10.883+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:03:10.893+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:03:10.913+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:03:10.913+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:03:10.913+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:03:10.933+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 14:03:10.933+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17177025
06-13 14:03:10.933+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17177082
06-13 14:03:10.933+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 14:03:10.933+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 14:03:10.933+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:03:10.933+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 14:03:10.943+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:03:10.943+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:03:10.943+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:10.943+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:10.943+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:10.963+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:03:10.973+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:10.973+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:03:10.973+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:03:10.973+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:03:10.973+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:03:10.983+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 14:03:10.983+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:03:10.983+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:03:10.983+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 14:03:11.093+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:03:11.103+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:03:11.113+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 14:03:11.113+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 14:03:11.123+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 14:03:11.163+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:03:11.163+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:03:11.163+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:11.163+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:11.163+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:11.163+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 16205 pgid = 16205
06-13 14:03:11.163+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(16205)
06-13 14:03:11.183+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:03:11.193+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:11.193+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:03:11.193+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:03:11.193+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:03:11.193+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:03:11.203+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:03:11.203+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:03:11.203+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:03:11.213+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[16205] terminate event is forwarded
06-13 14:03:11.213+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:03:11.213+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 16205, ]
06-13 14:03:11.213+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:03:11.213+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 14:03:11.213+0900 I/Tizen::App( 1175): (512) > Not registered pid(16205)
06-13 14:03:11.213+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 14:03:11.213+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:03:11.213+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 16205
06-13 14:03:11.213+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16205
06-13 14:03:11.213+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 16205
06-13 14:03:11.233+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:03:11.233+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 16205.
06-13 14:03:11.283+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:03:11.293+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:03:11.584+0900 I/UXT     (16589): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:03:11.644+0900 E/TBM     (16589): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:03:11.644+0900 I/MALI    (16589): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=16589   open drm_fd=29 
06-13 14:03:11.724+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17177933
06-13 14:03:11.744+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:03:11.744+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 14:03:11.764+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 14:03:11.764+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:03:11.764+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:03:11.764+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 14:03:11.794+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17177999
06-13 14:03:11.804+0900 E/EFL     (16589): edje<16589> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:03:11.804+0900 E/EFL     (16589): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:03:11.814+0900 E/EFL     (16589): edje<16589> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:03:11.814+0900 E/EFL     (16589): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:03:11.814+0900 E/EFL     (16589): edje<16589> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:03:11.814+0900 E/EFL     (16589): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:03:12.204+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17178415
06-13 14:03:12.304+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17178514
06-13 14:03:12.565+0900 W/cluster-view( 1167): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
06-13 14:03:12.705+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17178915
06-13 14:03:12.775+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17178982
06-13 14:03:12.775+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-13 14:03:12.775+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
06-13 14:03:12.775+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 1167
06-13 14:03:12.785+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 14:03:12.785+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:03:12.795+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:03:12.795+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:03:12.795+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:03:12.805+0900 I/abc     (16577): abc
06-13 14:03:12.805+0900 I/CAPI_APPFW_APPLICATION(16577): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:03:12.805+0900 I/CAPI_APPFW_APPLICATION(16577): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:03:12.835+0900 E/TBM     (16577): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:03:12.895+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 16577, appid: org.example.client
06-13 14:03:12.895+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:03:12.905+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(425) > request cmd(1) result(16577)
06-13 14:03:13.916+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 16577 pgid = 16577
06-13 14:03:13.916+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(16577)
06-13 14:03:13.926+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 16577.
06-13 14:03:13.926+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1662
06-13 14:03:13.956+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:03:13.956+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:03:13.956+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:03:13.956+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 16577.
06-13 14:03:13.956+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 16577
06-13 14:03:13.956+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16577
06-13 14:03:13.956+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 16577
06-13 14:03:13.966+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1663
06-13 14:03:14.737+0900 I/UXT     (16621): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:03:14.827+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17181034
06-13 14:03:14.827+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17181034
06-13 14:03:14.827+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 14:03:14.827+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 14:03:14.827+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 14:03:15.127+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:03:15.127+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:03:15.127+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:03:15.127+0900 E/STARTER (  721): )
06-13 14:03:15.137+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:03:15.137+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:03:15.137+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:03:15.137+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 14:03:15.147+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:03:15.147+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 14:03:15.147+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:03:15.147+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 14:03:15.147+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:03:15.157+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:03:15.167+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:03:15.167+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:03:15.167+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:03:15.177+0900 I/GXT_SIB (  342): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:03:15.187+0900 E/CAPI_APPFW_APPLICATION(16589): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:03:15.187+0900 E/CAPI_APPFW_APPLICATION(16589): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:03:15.187+0900 E/CAPI_APPFW_APPLICATION(16589): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:03:15.187+0900 E/CAPI_APPFW_APPLICATION(16589): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:03:15.187+0900 E/CAPI_APPFW_APPLICATION(16589): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:03:15.187+0900 I/CAPI_APPFW_APPLICATION(16589): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:03:15.187+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bdc6e9 in class 'Edje_Object'.
06-13 14:03:15.187+0900 E/UXT     (  342): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
06-13 14:03:15.187+0900 I/CAPI_APPFW_APPLICATION(16589): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:03:15.267+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 16589, appid: com.samsung.task-mgr
06-13 14:03:15.267+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:03:15.267+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(16589)
06-13 14:03:15.267+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 14:03:15.287+0900 W/TASK_MGR_LITE(16589): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 14:03:15.297+0900 I/GXT_SIB (16589): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:03:15.347+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:03:15.347+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:03:15.357+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.367+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:03:15.367+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:03:15.367+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.377+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:03:15.377+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.387+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.397+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:03:15.397+0900 E/RUA     (16589): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 24, ncols : 5
06-13 14:03:15.397+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:03:15.407+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.407+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 14:03:15.407+0900 E/TASK_MGR_LITE(16589): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 14:03:15.427+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.437+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.457+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:03:15.467+0900 W/CRASH_MANAGER(16473): worker.c: worker_job(1199) > 0416525636c69149733018
